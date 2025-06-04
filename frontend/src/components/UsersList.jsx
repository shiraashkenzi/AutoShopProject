import React, { useEffect, useState } from "react";
import axios from "axios";
import { Link } from "react-router-dom";

function UsersList() {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    axios.get("/api/users").then(res => setUsers(res.data));
  }, []);

  const deleteUser = id => {
    if (window.confirm("Are you sure you want to delete this user?")) {
      axios.delete(`/api/users/${id}`).then(() => {
        setUsers(prev => prev.filter(u => u.id !== id));
      });
    }
  };

  return (
    <div>
      <h2>User List</h2>
      <table className="table">
        <thead>
          <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Car</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {users.map(user => (
            <tr key={user.id}>
              <td>{user.name}</td>
              <td>{user.email}</td>
              <td>{user.car ? `${user.car.company} ${user.car.model}` : ""}</td>
              <td>
                <Link className="btn btn-sm btn-warning me-2" to={`/users/edit/${user.id}`}>Edit</Link>
                <button className="btn btn-sm btn-danger" onClick={() => deleteUser(user.id)}>Delete</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default UsersList;