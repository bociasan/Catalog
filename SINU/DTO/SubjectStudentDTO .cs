using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.Model;

namespace SINU.DTO
{
public class SubjectStudentDTO
{

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int StudyYearId { get; set; }
        public int Grade { get; set; }
        public int SubjectProfesorId { get; set; }
        public SubjectProfesor subjectProfesor { get; set; }
        public int SubjectId { get; set; }
        public DateTime Date { get; set; }

    }
}

