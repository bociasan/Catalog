import React from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
// import { Routes, Route, Switch,Redirect} from 'react-router-dom';
import Welcome from "./components/First Page/Welcome";
import Home from "./components/Student/Home";
import Profile from "./components/Student/Profile";
import Grades from "./components/Student/Grades";
import Settings from "./components/Student/Settings";
import Help from "./components/Student/Help";
import LogOut from "./components/Student/LogOut";
import T_Profile from "./components/Teacher/T_Profile";
import T_Grades from "./components/Teacher/T_Grades";
import T_Settings from "./components/Teacher/T_Settings";
import T_Help from "./components/Teacher/T_Help";
import T_LogOut from "./components/Teacher/T_LogOut";
// import { useRoutes } from 'hookrouter';



function App() {
  return (
    <div className="container">
      <Router>
        <Switch>
          <Route path="/" exact component={Welcome} />
          <Route path="/student" exact component={Home} />
          <Route path="/student/profile" component={Profile} />
          <Route path="/student/grades" component={Grades} />
          <Route path="/student/settings" component={Settings} />
          <Route path="/student/help" component={Help} />
          <Route path="/student/logout" component={LogOut} />
          
          <Route path='/teacher/profile' component={T_Profile}/>
          <Route path='/teacher/grades' component={T_Grades}/>
          <Route path='/teacher/settings' component={T_Settings}/>
          <Route path="/teacher/help" component={T_Help} />
          <Route path="/teacher/logout" component={T_LogOut} />
        </Switch>
      </Router>
    </div>
  );
}

export default App;
