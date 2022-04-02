import React, { useState } from "react";

import ModalRegister from "./ModalRegister";
import Backdrop from "./Backdrop";

function Register() {
  const [modalIsOpen, setModalIsOpen] = useState();
  
  function showModalHandler() {
    setModalIsOpen(true);
  }
  function closeModalHnadler() {
    setModalIsOpen(false);
  }

  return (
      <div className="loginRegister">
        <button onClick={showModalHandler}>Sign up</button>
      {modalIsOpen && <Backdrop onClick={closeModalHnadler} />}
      {modalIsOpen && <ModalRegister/>}
      </div>
  );
}
export default Register;