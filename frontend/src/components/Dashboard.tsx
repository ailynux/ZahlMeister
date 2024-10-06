import React, { useState, useEffect } from 'react';
import { fetchPayments } from '../api/paymentApi';
import PaymentList from './PaymentList';
import { Payment } from '../types';

const Dashboard: React.FC = () => {
    const [payments, setPayments] = useState<Payment[]>([]);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const loadPayments = async () => {
            try {
                const data = await fetchPayments();
                setPayments(data);
            } catch (err) {
                console.error('Failed to load payments:', err);
                setError('Failed to load payments');
            }
        };
        loadPayments();
    }, []);

    return (
        <div>
            <h1>Dashboard</h1>
            {error && <p style={{ color: 'red' }}>{error}</p>}
            <PaymentList payments={payments} />
        </div>
    );
};

export default Dashboard;
