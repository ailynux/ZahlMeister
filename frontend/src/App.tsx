//app.tsx
import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Dashboard from './components/Dashboard';
import Reports from './components/Reports';
import Login from './components/Login';
import SignUp from './components/SignUp';
import Navbar from './components/Navbar'; 
import './App.css';  // This is where Tailwind will be included

const App: React.FC = () => {
    return (
        <Router>
            <div className="min-h-screen bg-gray-100">
                <Navbar />
                <div className="container mx-auto p-4">
                    <Routes>
                        <Route path="/" element={<Dashboard />} />
                        <Route path="/reports" element={<Reports />} />
                        <Route path="/login" element={<Login />} />
                        <Route path="/signup" element={<SignUp />} />
                    </Routes>
                </div>
            </div>
        </Router>
    );
};

export default App;
