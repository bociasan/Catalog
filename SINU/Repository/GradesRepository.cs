﻿using System.Collections.Generic;
using SINU.Data;
using SINU.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

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
            gradeInfo.Date = DateTime.Now;
            _context.Grades.Add(gradeInfo);
            _context.SaveChanges();
            return gradeInfo;
        }

        public GradeInfo GetGradeById(int id)
        {
            return _context.Grades
                //.Include(s => s.Subject)
                .FirstOrDefault(s => s.Id == id);
        }

        public List<GradeInfo> GetAll()
        {
            return _context.Grades
                //.Include(s => s.Subject)
                //.Include(s => s.Student).ThenInclude(s => s.User)
                //.Include(g => g.SubjectProfesor).ThenInclude(g => g.User).Include(g => g.Subject)
                .ToList();
        }

        public List<GradeInfo> GetGradesByProfessorId(int id)
        {
            return _context.Grades
                //.Include(s => s.Subject)
                .Where(s => s.SubjectProfesorId == id)
                .ToList();
        }

        public List<GradeInfo> GetGradesByStudentId(int id)
        {
            return _context.Grades
                //.Include(s => s.Subject)
                .Where(s => s.StudentId == id)
                .ToList();
        }

        public GradeInfo Update(GradeInfo gradeInfo)
        {
            _context.Grades.Update(gradeInfo);
            _context.SaveChanges();
            return GetGradeById(gradeInfo.Id);
        }
    }
}
