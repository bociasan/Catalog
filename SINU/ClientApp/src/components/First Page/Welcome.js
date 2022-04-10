import React, { useState } from "react";
import Teacher from "./Teacher";
import Student from "./Student";
import "./welcome.css";

function Welcome() {
  const [studentIsOpen, setStudentIsOpen] = useState();
  const [teacherIsOpen, setTeacherIsOpen] = useState();

  return (
    <div className="welcomecontainer">
        
      <button
        className="navbar-button-student"
        onClick={() => {
          setStudentIsOpen(true);
          setTeacherIsOpen(false);
        }}
        style={{
          backgroundColor: studentIsOpen ? "white" : "rgba(0, 0, 0, 0.5)",
          color: studentIsOpen ? "rgb(24,29,82)" : "white",
        }}
      >
        Student
      </button>
      {studentIsOpen && <Student />}

      <button
        className="navbar-button-teacher"
        onClick={() => {
          setTeacherIsOpen(true);
          setStudentIsOpen(false);
        }}
        style={{
          backgroundColor: teacherIsOpen ? "white" : "rgba(0, 0, 0, 0.5)",
          color: teacherIsOpen ? "rgb(24,29,82)" : "white",
        }}
      >
        Teacher
      </button>
      {teacherIsOpen && <Teacher />}

      <div className="icon-toggle-between-student-teacher">

      </div>
    </div>
  );
}

export default Welcome;
