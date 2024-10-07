import React from 'react';
import { Payment } from '../types';

interface Props {
  payments: Payment[];
}

// Helper function to determine badge color based on payment status
const getStatusBadge = (status: string) => {
  switch (status) {
    case 'Success':
      return 'bg-green-100 text-green-700';
    case 'Pending':
      return 'bg-yellow-100 text-yellow-700';
    case 'Failed':
      return 'bg-red-100 text-red-700';
    default:
      return 'bg-gray-100 text-gray-700';
  }
};

const PaymentList: React.FC<Props> = ({ payments }) => {
  return (
    <div className="grid grid-cols-1 gap-6 sm:grid-cols-2 lg:grid-cols-3">
      {payments.map((payment) => (
        <div
          key={payment.paymentId}
          className="bg-white shadow-lg rounded-lg p-6 hover:shadow-2xl transition-shadow duration-300 ease-in-out"
        >
          <div className="flex justify-between items-center mb-4">
            <div>
              <h2 className="text-xl font-semibold">Payment #{payment.paymentId}</h2>
              <p className="text-gray-500 text-sm">User ID: {payment.userId}</p>
            </div>
            <div>
              <span
                className={`px-3 py-1 rounded-full text-sm font-semibold ${getStatusBadge(
                  payment.paymentStatus
                )}`}
              >
                {payment.paymentStatus}
              </span>
            </div>
          </div>

          <div className="text-gray-800">
            <p className="text-lg font-medium">
              Amount: <span className="font-bold text-blue-500">${payment.paymentAmount}</span>
            </p>
            <p className="text-sm text-gray-500">
              Date: {new Date(payment.paymentDate).toLocaleDateString()}
            </p>
          </div>

          {/* Action buttons for each payment */}
          <div className="mt-4 flex space-x-4">
            <button className="bg-blue-500 text-white px-4 py-2 rounded-full hover:bg-blue-700 transition">
              View Details
            </button>
            <button className="bg-gray-300 text-gray-700 px-4 py-2 rounded-full hover:bg-gray-400 transition">
              Refund
            </button>
          </div>
        </div>
      ))}
    </div>
  );
};

export default PaymentList;
