import React, { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import axios from "axios";

function UserForm() {
  const [user, setUser] = useState({ name: "", email: "", password: "", carId: "" });
  const [cars, setCars] = useState([]);
  const navigate = useNavigate();
  const { id } = useParams();

  useEffect(() => {
    axios.get("/api/cars").then(res => setCars(res.data));
    if (id) {
      axios.get(`/api/users/${id}`).then(res => setUser(res.data));
    }
  }, [id]);

  const handleSubmit = e => {
    e.preventDefault();
    const request = id ? axios.put(`/api/users/${id}`, user) : axios.post("/api/users", user);
    request.then(() => navigate("/users"));
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2>{id ? "Edit User" : "Add New User"}</h2>
      <div className="mb-3">
        <label className="form-label">Name</label>
        <input className="form-control" value={user.name} onChange={e => setUser({ ...user, name: e.target.value })} required />
      </div>
      <div className="mb-3">
        <label className="form-label">Email</label>
        <input className="form-control" value={user.email} onChange={e => setUser({ ...user, email: e.target.value })} required />
      </div>
      <div className="mb-3">
        <label className="form-label">Password</label>
        <input className="form-control" type="password" value={user.password} onChange={e => setUser({ ...user, password: e.target.value })} required={!id} />
      </div>
      <div className="mb-3">
        <label className="form-label">Assigned Car</label>
        <select className="form-select" value={user.carId || ""} onChange={e => setUser({ ...user, carId: e.target.value })}>
          <option value="">None</option>
          {cars.map(car => (
            <option key={car.id} value={car.id}>{car.company} {car.model}</option>
          ))}
        </select>
      </div>
      <button className="btn btn-success" type="submit">Save</button>
    </form>
  );
}

export default UserForm;