import Student from "./components/First Page/Student";
import Teacher from "./components/First Page/Teacher";
import React from "react";
import { Routes, Route, Switch,Redirect} from 'react-router-dom'
import Home from "./components/First Page/Home"
import Teachers from "./components/Teachers Page/displayTableTeachers"
import Teachers400 from "./components/Teachers Page/displayTableTeachersError400"
import TeachersList from "./components/Teachers Page/displayTableTeachersList"
import Welcome from "./components/First Page/Welcome"
import { useRoutes } from 'hookrouter';


function App() {

    const routes = {
        // '/': () => <Welcome />,
        /*'/': () => <Teachers400 />,*/
        '/l': () => <TeachersList />,
        '/t': () => <Teachers />,
        '/home': () => <Home />,

    };
    const routeResults = useRoutes(routes);


    return (
      <div className="container">
          {routeResults}
      </div>
)}

export default App;

