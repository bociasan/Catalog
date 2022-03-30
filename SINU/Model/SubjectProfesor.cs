using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SINU.Model
{
    public class SubjectProfesor
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        [ForeignKey("StudyYear")]
        public int StudyYearId { get; set; }
        Subject Subject { get; set; }
        User User { get; set; }
    }
}
