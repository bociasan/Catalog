using System.Collections.Generic;
using SINU.Model;

namespace SINU.VM { 
    public class ClassVM
    {



        public Teacher Mentor { get; set; }
        public List<Student> Students { get; set; }
        public List<SubjectClass> Subjectss { get; set; }

    }
}