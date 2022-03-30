using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SINU.Data;
using SINU.Model;

namespace SINU.Repository
{
    public class ClassRepository : IClassRepository
    {

        private readonly AppDbContext _context;

        public ClassRepository(AppDbContext context)
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
            //return _context.Classes.Include(c => c.Mentor).FirstOrDefault(c => c.Id == id);
            var resultClass = _context.Classes.Include(c => c.Mentor).FirstOrDefault(c => c.Id == id);
            //List students = _context.Students.FirstOrDefault(c => c.ClassId == resultClass.Id).ToList();
            resultClass.Mentor.Password = null;
            resultClass.Mentor.IDNP = null; 
            resultClass.Mentor.Address = null;
            resultClass.Mentor.Username = null;
            resultClass.Students = _context.Students.Where(s => s.ClassId==resultClass.Id).ToList();
            resultClass.Subjects = _context.SubjectsClass.Where(s => s.ClassId == resultClass.Id).ToList();
            return resultClass;
        }
    }
}
