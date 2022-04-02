using System.Collections.Generic;
using SINU.Model;

namespace SINU.VM { 
    public class ClassVM
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Letter { get; set; }
        public int StudyYearId { get; set; }
        public int StudyYearName { get; set; }
        public int MentorId { get; set; }
        public string MentorFirstName { get; set; }
        public string MentorLastName { get; set; }
    }
}