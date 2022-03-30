import React, { useState } from "react";

import Modal from "./Modal";
import Backdrop from "./Backdrop";


function Login() {


   


  const [modalIsOpen, setModalIsOpen] = useState();
  
  function showModalHandler() {
    setModalIsOpen(true);
  }
  function closeModalHnadler() {
    setModalIsOpen(false);
  }

  return (
      <div className="loginRegister">
        <button onClick={showModalHandler}>Login</button>
      {modalIsOpen && <Backdrop onClick={closeModalHnadler} />}
      {modalIsOpen && <Modal/>}
      </div>
  );
}
export default Login;
