import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";

function CarForm() {
  const [car, setCar] = useState({ company: "", model: "" });
  const navigate = useNavigate();

  const handleSubmit = e => {
    e.preventDefault();
    axios.post("/api/cars", car).then(() => navigate("/cars"));
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2>Add New Car</h2>
      <div className="mb-3">
        <label className="form-label">Company</label>
        <input className="form-control" value={car.company} onChange={e => setCar({ ...car, company: e.target.value })} required />
      </div>
      <div className="mb-3">
        <label className="form-label">Model</label>
        <input className="form-control" value={car.model} onChange={e => setCar({ ...car, model: e.target.value })} required />
      </div>
      <button className="btn btn-success" type="submit">Save</button>
    </form>
  );
}

export default CarForm;