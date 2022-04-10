import React from "react";
import * as AiIcons from "react-icons/ai";
import * as IoIcons from "react-icons/io";
import * as BiIcons from "react-icons/bi";
import * as CgIcons from "react-icons/cg";
import * as RiIcons from "react-icons/ri";

export const NavBarDataTeacher = [
  {
    title: "Profile",
    path: "/teacher/profile",
    icon: <CgIcons.CgProfile style={{ fontSize: "32px" }} />,
    cName: "nav-text-teacher",
  },
  {
    title: "Grades",
    path: "/teacher/grades",
    icon: <IoIcons.IoIosCreate style={{ fontSize: "32px" }} />,
    cName: "nav-text-teacher",
  },
  {
    title: "Settings",
    path: "/teacher/settings",
    icon: <AiIcons.AiFillSetting style={{ fontSize: "32px" }} />,
    cName: "nav-text-teacher",
  },
  {
    title: "Help",
    path: "/teacher/help",
    icon: <BiIcons.BiHelpCircle style={{ fontSize: "32px" }} />,
    cName: "nav-text-teacher",
  },
  {
    title: "Log out",
    path: "/teacher/logout",
    icon: <RiIcons.RiLogoutBoxRLine style={{ fontSize: "32px" }} />,
    cName: "nav-text-teacher",
  },
];
