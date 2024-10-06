import React from 'react';

const Reports: React.FC = () => {
  const downloadReport = () => {
    window.open('http://localhost:5000/api/payment/generate-report', '_blank');
  };

  return (
    <div>
      <h1>Reports</h1>
      <button onClick={downloadReport}>Download Report</button>
    </div>
  );
};

export default Reports;
export {}; 