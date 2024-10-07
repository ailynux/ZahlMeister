//reports.tsx

import React from 'react';

const Reports: React.FC = () => {
    const downloadReport = () => {
        window.open('http://localhost:5000/api/payment/generate-report', '_blank');
    };

    return (
        <div className="p-8">
            <h1 className="text-4xl font-bold mb-6">Reports</h1>
            <button
                onClick={downloadReport}
                className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded"
            >
                Download Report
            </button>
        </div>
    );
};

export default Reports;
