import React, { useEffect, useState } from "react";
import axios from "axios";

function CarsList() {
  const [cars, setCars] = useState([]);

  useEffect(() => {
    axios.get("/api/cars").then(res => setCars(res.data));
  }, []);

  const deleteCar = id => {
    axios.delete(`/api/cars/${id}`).then(() => {
      setCars(prev => prev.filter(c => c.id !== id));
    }).catch(err => alert("Cannot delete car that is assigned to users"));
  };

  return (
    <div>
      <h2>Car List</h2>
      <table className="table">
        <thead>
          <tr>
            <th>Company</th>
            <th>Model</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {cars.map(car => (
            <tr key={car.id}>
              <td>{car.company}</td>
              <td>{car.model}</td>
              <td><button className="btn btn-sm btn-danger" onClick={() => deleteCar(car.id)}>Delete</button></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default CarsList;
