import React from 'react';
import { Payment } from '../types';

interface Props {
  payments: Payment[];
}

const PaymentList: React.FC<Props> = ({ payments }) => {
  return (
    <table>
      <thead>
        <tr>
          <th>ID</th>
          <th>User ID</th>
          <th>Status</th>
          <th>Amount</th>
          <th>Date</th>
        </tr>
      </thead>
      <tbody>
        {payments.map(payment => (
          <tr key={payment.paymentId}>
            <td>{payment.paymentId}</td>
            <td>{payment.userId}</td>
            <td>{payment.paymentStatus}</td>
            <td>{payment.paymentAmount}</td>
            <td>{new Date(payment.paymentDate).toLocaleDateString()}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default PaymentList;
export {}; 