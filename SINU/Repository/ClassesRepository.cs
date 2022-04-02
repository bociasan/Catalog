using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SINU.Data;
using SINU.Model;
using SINU.DTO;

namespace SINU.Repository
{
    public class ClassesRepository : IClassesRepository
    {

        private readonly AppDbContext _context;

        public ClassesRepository(AppDbContext context)
        {
            _context = context;
        }
        public Class Create(Class Class)
        {
            _context.Classes.Add(Class);
            _context.SaveChanges();
            return GetClassById(Class.Id);
        }

        public List<Class> GetAll()
        {
            return _context.Classes.ToList();
        }

        public Class GetClassById(int id)
        {
            //var resultClass = _context.Classes.Include(s=>s.Students).FirstOrDefault(c => c.Id == id);
            //resultClass.Mentor = new Teacher(_context.Users.FirstOrDefault(u => u.Id == resultClass.MentorId));
            //resultClass.Students = _context.Students.Include(s => s.User).Where(s => s.ClassId == id).ToList().ConvertAll(x => new StudentDTO(x));
            //resultClass.Subjects = _context.SubjectsClass.Include(s => s.Subject).Include(s => s.SubjectProfesor)
            //    .Where(s => s.ClassId == id).ToList().ConvertAll(x => new SubjectClassDTO(x));

            //foreach (SubjectClassDTO subject in resultClass.Subjects)
            //{
            //    var teacher = _context.SubjectsProfesor.Include(s => s.User).FirstOrDefault(s => s.Id == subject.SubjectProfesorId);
            //    subject.TeacherFirstName = teacher.User.FirstName;
            //    subject.TeacherLastName = teacher.User.LastName;
            //}
            //return resultClass;
            return _context.Classes.FirstOrDefault(c => c.Id == id);
        }
    }
}
