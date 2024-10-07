import React from 'react';
import { Link } from 'react-router-dom';
import { FaTachometerAlt, FaFileAlt, FaSignInAlt, FaUserPlus } from 'react-icons/fa'; // Added FaUserPlus for Sign-Up

const Navbar: React.FC = () => {
    return (
        <nav className="bg-gradient-to-r from-blue-500 to-purple-600 shadow-lg">
            <div className="container mx-auto px-4">
                <ul className="flex justify-between items-center py-4">
                    <li className="text-2xl font-bold text-white">
                        <Link to="/" className="hover:text-gray-300">
                            ZahlMeister
                        </Link>
                    </li>
                    <li>
                        <ul className="flex space-x-8 text-lg">
                            <li>
                                <Link
                                    to="/"
                                    className="flex items-center space-x-2 text-white hover:text-gray-300 transition duration-300"
                                >
                                    <FaTachometerAlt />
                                    <span>Dashboard</span>
                                </Link>
                            </li>
                            <li>
                                <Link
                                    to="/reports"
                                    className="flex items-center space-x-2 text-white hover:text-gray-300 transition duration-300"
                                >
                                    <FaFileAlt />
                                    <span>Reports</span>
                                </Link>
                            </li>
                            <li>
                                <Link
                                    to="/login"
                                    className="flex items-center space-x-2 text-white hover:text-gray-300 transition duration-300"
                                >
                                    <FaSignInAlt />
                                    <span>Login</span>
                                </Link>
                            </li>
                            <li>
                                <Link
                                    to="/signup"
                                    className="flex items-center space-x-2 text-white hover:text-gray-300 transition duration-300"
                                >
                                    <FaUserPlus />
                                    <span>Sign Up</span>
                                </Link>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </nav>
    );
};

export default Navbar;
