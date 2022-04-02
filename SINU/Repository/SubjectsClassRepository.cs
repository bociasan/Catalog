using System.Collections.Generic;
using System.Linq;
using SINU.Data;
using SINU.Model;

namespace SINU.Repository
{
    public class SubjectsClassRepository : ISubjectsClassRepository
    {

        private readonly AppDbContext _context;

        public SubjectsClassRepository(AppDbContext context)
        {
            _context = context;
        }
        public SubjectClass Create(SubjectClass subjectClass)
        {
            _context.SubjectsClass.Add(subjectClass);
            _context.SaveChanges();
            return GetSubjectClassById(subjectClass.Id);
        }

        public List<SubjectClass> GetAll()
        {
            return _context.SubjectsClass.ToList();
        }

        public SubjectClass GetSubjectClassById(int id)
        {
            return _context.SubjectsClass.FirstOrDefault(s => s.Id == id);
        }
    }
}
