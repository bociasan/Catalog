using System.Collections.Generic;
using SINU.Data;
using SINU.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SINU.Repository
{
    public class GradesRepository : IGradesRepository
    {
        private readonly AppDbContext _context;

        public GradesRepository(AppDbContext context)
        {
            _context = context;
        }
        public GradeInfo Create(GradeInfo gradeInfo)
        {
            _context.Grades.Add(gradeInfo);
            _context.SaveChanges();
            return _context.Grades.FirstOrDefault(s => s.Id == gradeInfo.Id);
        }

        public GradeInfo GetGradeById(int id)
        {
            return _context.Grades.FirstOrDefault(s => s.Id == id);
        }

        public List<GradeInfo> GetAll()
        {
            return _context.Grades.ToList();
        }
    }
}
