import React, { useState, useEffect } from 'react';
import { fetchPayments } from '../api/paymentApi';
import PaymentList from './PaymentList';
import { Payment } from '../types';

const Dashboard: React.FC = () => {
    const [payments, setPayments] = useState<Payment[]>([]);
    const [loading, setLoading] = useState<boolean>(true); // Added loading state
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const loadPayments = async () => {
            try {
                const data = await fetchPayments();
                setPayments(data);
                setLoading(false); // Stop loading once data is fetched
            } catch (err) {
                console.error('Failed to load payments:', err);
                setError('Failed to load payments. Please try again.');
                setLoading(false); // Stop loading if there's an error
            }
        };
        loadPayments();
    }, []);

    return (
        <div className="p-8 bg-gradient-to-r from-gray-100 to-gray-200 min-h-screen">
            <h1 className="text-5xl font-extrabold text-center text-blue-700 mb-8">Dashboard</h1>

            {/* Show error message if there's an error */}
            {error && (
                <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-6">
                    <strong className="font-bold">Error: </strong>
                    <span className="block sm:inline">{error}</span>
                </div>
            )}

            {/* Show loading spinner while fetching data */}
            {loading ? (
                <div className="flex justify-center items-center">
                    <div className="animate-spin rounded-full h-16 w-16 border-t-4 border-blue-500 border-solid"></div>
                </div>
            ) : (
                <div className="bg-white shadow-md rounded-lg p-6">
                    <PaymentList payments={payments} />
                </div>
            )}
        </div>
    );
};

export default Dashboard;
