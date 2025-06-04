import React from "react";
import { Routes, Route, NavLink } from "react-router-dom";
import UsersList from "./components/UsersList";
import UserForm from "./components/UserForm";
import CarsList from "./components/CarsList";
import CarForm from "./components/CarForm";

function App() {
  return (
    <div className="container mt-4">
      <nav className="mb-4">
        <NavLink className="btn btn-primary me-2" to="/users">Users</NavLink>
        <NavLink className="btn btn-secondary me-2" to="/users/create">Add User</NavLink>
        <NavLink className="btn btn-info me-2" to="/cars">Cars</NavLink>
        <NavLink className="btn btn-success" to="/cars/create">Add Car</NavLink>
      </nav>
      <Routes>
        <Route path="/users" element={<UsersList />} />
        <Route path="/users/create" element={<UserForm />} />
        <Route path="/users/edit/:id" element={<UserForm />} />
        <Route path="/cars" element={<CarsList />} />
        <Route path="/cars/create" element={<CarForm />} />
      </Routes>
    </div>
  );
}

export default App;