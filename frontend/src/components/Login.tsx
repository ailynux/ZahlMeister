import React, { useState } from 'react';

const Login: React.FC = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');

    const handleLogin = (e: React.FormEvent) => {
        e.preventDefault();
        // Handle login logic here (e.g., call login API)
        console.log('Logging in:', { username, password });
    };

    return (
        <form onSubmit={handleLogin} className="max-w-md mx-auto p-6 border rounded-lg shadow-lg bg-white">
            <h2 className="text-2xl font-bold mb-6 text-center text-blue-600">Login</h2>
            <div className="mb-4">
                <label className="block text-gray-700 text-sm font-bold mb-2">Username</label>
                <input
                    type="text"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    className="w-full px-3 py-2 border rounded"
                    placeholder="Enter your username"
                />
            </div>
            <div className="mb-4">
                <label className="block text-gray-700 text-sm font-bold mb-2">Password</label>
                <input
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    className="w-full px-3 py-2 border rounded"
                    placeholder="Enter your password"
                />
            </div>
            <button type="submit" className="w-full bg-blue-500 hover:bg-blue-700 text-white py-2 px-4 rounded">
                Login
            </button>

            <div className="text-center mt-4">
                <p className="text-gray-600">
                    Don't have an account?{' '}
                    <a href="/signup" className="text-blue-600 hover:underline">
                        Sign Up
                    </a>
                </p>
            </div>
        </form>
    );
};

export default Login;
