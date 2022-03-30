import Login from "./Login";
import Register from "./Register";
import React from "react";

function Teacher(props) {
  return (
    <div className="teacherContainer">
      <div className="teacherText">
        <p>Teacher</p>
      </div>
      <div className="loginRegister">
        <Login />
        <Register />
      </div>
    </div>
  );
}
export default Teacher;
