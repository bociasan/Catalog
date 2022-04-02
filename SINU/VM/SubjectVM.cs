﻿using SINU.Model;

namespace SINU.VM
{
    public class SubjectClassVM
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int SubjectProfesorId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }


        public SubjectClassVM()
        {

        }

        public SubjectClassVM(SubjectClass subjectClass)
        {
            Id = subjectClass.Id;
            ClassId = subjectClass.ClassId;
            SubjectId = subjectClass.SubjectId;
            SubjectProfesorId = subjectClass.SubjectProfesorId;
            Name = subjectClass.Subject.Name;
            About = subjectClass.Subject.About;
            //TeacherFirstName = subjectClass.User.FirstName;
            //TeacherLastName = subjectClass.User.LastName;

        }

    }
}