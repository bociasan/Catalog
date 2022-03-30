﻿using System.Collections.Generic;
using SINU.Data;
using SINU.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SINU.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return _context.Students.FirstOrDefault(s => s.UserId == student.UserId);
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            //var student = _context.Students.FirstOrDefault(s => s.Id == id);
            //student.User = _context.Users.FirstOrDefault(u => u.Id == student.UserId);
            //student.Class = _context.Classes.FirstOrDefault(c => c.Id == student.ClassId);
            return _context.Students.Include(s=>s.User).Include(s => s.Class).FirstOrDefault(s => s.Id == id);

        }
    }
}
