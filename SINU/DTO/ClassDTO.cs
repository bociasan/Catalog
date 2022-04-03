using System.Collections.Generic;
using SINU.Model;

namespace SINU.DTO {
    public class ClassDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Letter { get; set; }
        public int StudyYearId { get; set; }
        public string StudyYearName { get; set; }
        public int MentorId { get; set; }
        public string MentorFirstName { get; set; }
        public string MentorLastName { get; set; }


        public ClassDTO()
        {

        }

        public ClassDTO(Class classs)
        {
            this.Id = classs.Id;
            this.Number = classs.Number;
            this.Letter = classs.Letter;
            this.StudyYearId = classs.StudyYearId;
            this.StudyYearName = classs.StudyYear.Year;
            this.MentorId = classs.MentorId;
            this.MentorFirstName = classs.Mentor.FirstName;
            this.MentorLastName = classs.Mentor.LastName;

        }

    }

}