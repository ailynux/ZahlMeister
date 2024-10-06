import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Dashboard from './components/Dashboard';
import Reports from './components/Reports';
import Login from './components/Login'; // Optional
import './App.css';

const App: React.FC = () => {
  return (
    <Router>
      <div>
        <Routes>
          <Route path="/" element={<Dashboard />} />
          <Route path="/reports" element={<Reports />} />
          <Route path="/login" element={<Login />} /> {/* Optional */}
        </Routes>
      </div>
    </Router>
  );
};

export default App;

