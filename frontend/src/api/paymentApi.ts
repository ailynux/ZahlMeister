import axios from 'axios';

const API_URL = 'http://localhost:5000/api/payment';

export const fetchPayments = async () => {
    try {
        const response = await axios.get(API_URL, {
            headers: {
                'Content-Type': 'application/json',
            },
        });
        return response.data; // Assuming the response is in the expected format
    } catch (error: any) { // Cast error to any type
        console.error('Error fetching payments:', error.message || error);
        throw error; // Propagate the error
    }
};
