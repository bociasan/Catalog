using System.Collections.Generic;
using System.Linq;
using SINU.Data;
using SINU.Model;

namespace SINU.Repository
{
    public class SubjectStudentRepository : ISubjectStudentRepository
    {
        
        private readonly AppDbContext _context;

        public SubjectStudentRepository(AppDbContext context)
        {
            _context = context;
        }
        

        public SubjectStudent Create(SubjectStudent subjectStudent)
        {
            _context.SubjectsStudent.Add(subjectStudent);
            _context.SaveChanges();
            return GetSubjectStudentById(subjectStudent.Id);
        }


        public SubjectStudent GetSubjectStudentById(int id)
        {
            return _context.SubjectsStudent.FirstOrDefault(s => s.Id == id);
        }

        public List<SubjectStudent> GetSubjectStudentBySubjectId(int id)
        {
            return _context.SubjectsStudent.Where(s => s.SubjectId == id).ToList();
        }

        List<SubjectStudent> ISubjectStudentRepository.GetAll()
        {
            return _context.SubjectsStudent.ToList();
        }
    }
}
