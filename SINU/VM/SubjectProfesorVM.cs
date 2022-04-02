namespace SINU.Model
{
    public class SubjectProfesorVM
    {
        public int SubjectProfesorId { get; set; }
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int StudyYearId { get; set; }
        public string StudyYearName { get; set; }




        public SubjectProfesorVM() { }

        public SubjectProfesorVM(SubjectProfesor subjectProfesor)
        {
            this.SubjectProfesorId = subjectProfesor.Id;
            this.UserId = subjectProfesor.UserId;
            this.SubjectId = subjectProfesor.SubjectId;
            this.SubjectName = subjectProfesor.Subject.Name;
            this.StudyYearId = subjectProfesor.StudyYearId;
            this.StudyYearName = subjectProfesor.StudyYear.Year;
        }



    }
}
