import Student from "./components/First Page/Student";
import Teacher from "./components/First Page/Teacher";
import React from "react";
import { Routes, Route, Switch,Redirect} from 'react-router-dom'
import Home from "./components/First Page/Home"
import Teachers from "./components/Teachers Page/displayTableTeachers"
import Welcome from "./components/First Page/Welcome"
import { useRoutes } from 'hookrouter';


function App() {

    const routes = {
        // '/': () => <Welcome />,
        '/': () => <Teachers />,
        '/home': () => <Home />,

    };
    const routeResults = useRoutes(routes);


    return (
      <div className="container">
          {routeResults}
      </div>
)}

export default App;

