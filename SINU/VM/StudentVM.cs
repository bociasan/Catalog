using SINU.Model;

namespace SINU.VM
{
    public class StudentVM
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int UserId { get; set; }
        public int StudyYearId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public StudentVM()
        {

        }

        public StudentVM(Student student)
        {
            Id = student.Id;
            ClassId = student.ClassId;
            UserId = student.UserId;
            StudyYearId = student.StudyYearId;
            FirstName = student.User.FirstName;
            LastName = student.User.LastName;
        }

    }
}