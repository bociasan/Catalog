using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SINU.Model
{
    [Table("Classes")]
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public string Letter { get; set; }

        public int StudyYearId { get; set; }
        public int MentorId { get; set; }
        public User Mentor { get; set; }
        public List<Student> Students { get; set; }
        public List<SubjectClass> Subjects { get; set; }
    }
}
