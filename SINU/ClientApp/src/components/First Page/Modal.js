import React, { useState, useEffect } from "react";
import {FontAwesomeIcon} from "@fortawesome/react-fontawesome"
import { faEye } from '@fortawesome/free-solid-svg-icons'
import { faEyeSlash } from '@fortawesome/free-solid-svg-icons'
import Axios from "axios";

function Modal(props) {
  
  const url = "https://localhost:44328/api/login";

  const initialValues = {
    email: "",
    password: "",
  };

  const [formValues, setFormValues] = useState(initialValues);
  const [formErrors, setFormErrors] = useState({});
    const [isSubmit, setIsSubmit] = useState(false);
    const errors = {}
    const handleChange = (e) => {
     //console.log(formValues);
    const { name, value } = e.target;
    setFormValues({ ...formValues, [name]: value });
    
  };
 
  const handleSubmit = (e) => {
      e.preventDefault();

      if (Object.keys(validate(formValues)).length === 0) {
          Axios.post(url, {
              email: formValues.email,
              password: formValues.password,
          })
              .then((response) => {
                  //console.log(response.formValues.email);
                  window.location.href = "/student/profile";
              })
              .catch((err) => {
                  formErrors.password = "";formErrors.email = "";
                  if (err.response.status === 400) {
                      formErrors.password = "Invalid Password";
                      console.log("error")
                  }
                  if (err.response.status === 404) {
                      formErrors.email = "Account doesnt exists";
                      console.log("errorrrrrr404")
                  }
                  setFormErrors(formErrors)
              });

      }
     
      setFormErrors(validate(formValues));
      setIsSubmit(true);
     
    };
 
    const validate = (values) => {
      
        const regex = /^[^\s@]+@[^\s@]+\.[^\s@]{2,}$/i;
        if (!values.email) {
            errors.email = "Email is required!";
        } else if (!regex.test(values.email)) {
            errors.email = "This is not a valid email format!";
        }
        if (!values.password) {
            errors.password = "Password is required";
        }
        return errors;
    };

  useEffect(() => {
    //console.log(formErrors);
    if (Object.keys(formErrors).length === 0 && isSubmit) {
      console.log(formValues);
    }
  }, [formErrors]);

  const usePasswordToggle = () =>{

    const[visible,setVisiblity] = useState(false);

    const Icon = (
      <FontAwesomeIcon
         icon={visible ?  faEye : faEyeSlash}
         onClick={()=> setVisiblity(visiblity => !visiblity)}
         style={{ fontSize: "24px" , color: "gray"}}/>
    );
    const InputType = visible ? "text":"password";
    return [InputType,Icon]
  }
  const [PasswordInputType,ToogleIcon] = usePasswordToggle();

  return (
      <div className="modalLogin">
         
      <form onSubmit={handleSubmit}>
        <h3>Log In</h3>
        <div className="inputField">
          <h1>Email</h1>
          <input
            type="text"
            className="inputLogin"
            placeholder="Enter email"
            name="email"
            value={formValues.email}
            onChange={handleChange}
          />
          <h2>{formErrors.email}</h2>
        </div>
        <div className="inputField">
          <h1>Password</h1>
          <input
            type={PasswordInputType}
            className="inputLogin"
            placeholder="Password"
            name="password"
            value={formValues.password}
            onChange={handleChange}
          />
          <h2>{formErrors.password}</h2>
          <div className="password-toggle-icon-from-login">{ToogleIcon}</div>
        </div>

        <button type="submit"className="button-login">Log in</button>
        <h4>Not a member?<button className="sign-up-from-login-modal" onClick={()=> {props.closeLogin(false);props.openSignUp(true)}}>Sign In</button></h4>
      </form>
    </div>
  );
}

export default Modal;
