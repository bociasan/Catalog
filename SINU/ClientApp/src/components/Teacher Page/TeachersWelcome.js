import Login from "./Login";
import Register from "./Register";
import React from "react";
import Teacher from "./Teachers"
import Student from "./Student"
import '../../index.css'

function TeachersWelcome(props) {
    return (
        <div className="teachersContainer">
            <Teachers />
        </div>
    );
}

export default TeachersWelcome;
