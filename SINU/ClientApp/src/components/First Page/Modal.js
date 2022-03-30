import React, { useState,useEffect} from 'react';
import Axios from 'axios';
import { useForm } from "react-hook-form";
import { useNavigate } from 'react-router-dom';

function Modal() {

    const url = "https://localhost:44328/api/login";


    const [data, setData] = useState({

        Email: "",
        Password: "",


    }
    )




    function handle(e) {

        const newdata = { ...data }
        newdata[e.target.id] = e.target.value;
        setData(newdata)
        console.log(newdata)
    }


    function submit(e) {

        e.preventDefault();
        Axios.post(url, {
          
            Email: data.Email,
            Password: data.Password,

        }).then(response => {
     
            window.location.href = '/home';
        }) .catch(err => {
            if (err.response.status === 405) {
  
                console.log("invalid credentials");
            }
        })

   

       
    

    }

    


  return (
    <div className="modal">
          <form onSubmit={(e) => submit(e)} >
        <h3>Login</h3>
              <input type="email"
                  className="email-modal"
                  placeholder="Email"
                  name="Email"
                  required
                  id="Email"
                  value={data.Email}
                  onChange={(e) => handle(e)}
              />
              <input type="password"
                  className="password-modal"
                  placeholder="Password"
                  id="Password"
                  name="Password"
                  value={data.Password}
                  onChange={(e) => handle(e)}
              />
        <p className="forgot-password">
          Forgot&nbsp;<a href=""> password</a>?
              </p>
              <button type="submit" className="button-login"  >Log in</button>
        <h4>or  <a href="">Sign Up </a>
    </h4>
      </form>
      
    </div>
  )
}

export default Modal;
