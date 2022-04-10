import React from "react";
import NavBar from "../NavBar/NavBar";
import * as BiIcons from "react-icons/bi";
import * as IoIosIcons from "react-icons/io";
import * as BsIcons from "react-icons/bs";
import * as MdIcons from "react-icons/md";
import './student.css'
function Profile() {
  return (
    <div className="profileContainer">
      <NavBar />
      <div className="cardContainer">
        <div className="cardTop">
        <div className="ProfilePic"></div>
        </div>
        
        <div className="cardButtom">
          
          <div className="cardDetails">
            <div class="grid-item">
               Mark
               <div className="line">
                  <BiIcons.BiMedal style={{ fontSize: 30, color: "rgb(247,185,0)" }} />
                   9.5
               </div>
            </div>

            <div class="grid-item2">
               Class
                  <div className="line">
                    <IoIosIcons.IoIosSchool style={{ fontSize: 30, color: "red" }} />
                    10 C
                 </div> 
            </div>

            <div class="grid-item">
              Study year
                <div className="line">
                    <BsIcons.BsCalendarDate style={{ fontSize: 28, color: "blue" }} />
                    2019-20
                </div> 
            </div>
          </div>
          <div className="studentName">
            Boiciuc Alexandru
            <div className="studentEmail">boiciucsandu@gmail.com  
            <MdIcons.MdOutlineEmail style={{ fontSize: 28, color: "gray" }} />  
              
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
export default Profile;
