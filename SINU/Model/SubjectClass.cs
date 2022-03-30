using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SINU.Model
{

    public class SubjectClass
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectProfesor")]
        public int SubjectProfesorId { get; set; }

    }
}
