import Login from "./Login";
import Register from "./Register";
import React from "react";
import Teacher from "./Teacher"
import Student from "./Student"
import '../../index.css'



function Welcome(props) {




    return (

     

        <div className="welcomeContainer">
            <div className="teacherContainer">
            <Teacher />
            </div>
            <div className="studentContainer">
                <Student />
                </div>

        </div>
    );
}

export default Welcome;
