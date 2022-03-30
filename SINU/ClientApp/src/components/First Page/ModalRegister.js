import React from "react";

import { useEffect, useState } from 'react';
import { useForm } from "react-hook-form";
import { useNavigate } from 'react-router-dom';
import Axios from "axios";






function ModalRegister() {


    const [data, setData] = useState  ( {

                Username : "",
                Email : "",
                Password : "",
                Confirm : "",
                IDNP : ""

        }
    )

    
    const url = "https://localhost:44328/api/register";



 
//   const navigate = useNavigate();
  //  navigate('/Home');


    function handle(e) {

        const newdata = {...data }
        newdata[e.target.id] = e.target.value;
        setData(newdata)
        console.log(newdata)
    }


    function submit(e) {

        e.preventDefault();
        Axios.post(url, {
            Username: data.Username,
            Email: data.Email,
            Password: data.Password,
            IDNP: data.IDNP


        }).then(res => { console.log(res.data)})



    }

  return (
      <div id="registerModal" className="modal">
          <form onSubmit={(e) => submit(e)}>
        <h3>Register</h3>

              <input
                  name="Username"
                  required
                  id="Username"
                  type="text"
                  className="password-modal"
                  placeholder="Enter username"
                  value={data.Username}
                  onChange={(e) => handle(e) }
        
        />

              <input type="Email"
                  placeholder="Enter email"
                  required
                  id="Email"
                  type="text"
                  className="password-modal"
                  placeholder="Enter Email"
                  value={data.Email}
                  onChange={(e) => handle(e)}
                       />

              <input
          name="Password"
          required
          id="Password"
          type="password"
          className="password-modal"
           placeholder="Enter password"
                  value={data.Password}
                  onChange={(e) => handle(e)}
                  
        />

              <input
          name="Confirm"
          required
          id="Confirm"
          type="password"
          className="password-modal"
                  placeholder="Confirm password"
                  value={data.Confirm}
                  onChange={(e) => handle(e)}
              
        />

        <div className="form-group">
          <label>Identification Code</label>
                  <input
            name="IDNP"
            required
            id="IDNP"
            type="text"
            className="password-modal"
            placeholder="Enter ID"
                      value={data.IDNP}
                      onChange={(e) => handle(e)}
           
          />
        </div>
        

              <button type="submit" className="button-login">
            Sign up
          </button>       
      </form>
    </div>
  );
}

export default ModalRegister;
