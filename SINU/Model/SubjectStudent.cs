using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SINU.Model
{
    public class SubjectStudent
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("StudyYear")]
        public int StudyYearId { get; set; }
        public int Grade { get; set; }
        [ForeignKey("SubjectProfesor")]
        public int SubjectProfesorId { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public DateTime Date { get; set; }

    }
}
