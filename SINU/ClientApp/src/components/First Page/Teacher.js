import Backdrop from "./Backdrop";
import React, { useState } from "react";
import Modal from "./Modal";
import ModalRegister from "./ModalRegister";
import StudentCard from "./studentt.png"
function Teacher() {
  const [loginIsOpen, setLoginIsOpen] = useState();
  const [registerIsOpen, setRegisterIsOpen] = useState();

  return (
    <div className="teacher-card">
      
      <div className="student-card-text">
       Welcome <br/>
       Back To <br/>
       Catalog Online
      </div>  

      <div className="student-card-buttons">
        <button className="teacher-card-button-login" onClick={()=> setLoginIsOpen(true)}>Log in</button>
        {loginIsOpen && <Backdrop onClick={()=> setLoginIsOpen(false)} />}
        {loginIsOpen && <Modal closeLogin={setLoginIsOpen} openSignUp={setRegisterIsOpen}/>}
        <button className="teacher-card-button-signup" onClick={()=> setRegisterIsOpen(true)}>Sign up</button>
        {registerIsOpen && <Backdrop onClick={()=>setRegisterIsOpen(false)} />}
        {registerIsOpen && <ModalRegister closeSignUp={setRegisterIsOpen} openLogin={setLoginIsOpen}/>}
      </div>
      

    </div>
  );
}
export default Teacher;
