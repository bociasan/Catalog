﻿using System.Collections.Generic;
using System.Linq;
using SINU.Data;
using SINU.Model;

namespace SINU.Repository
{
    public class StudyYearsRepository : IStudyYearsRepository
    {
        private readonly AppDbContext _context;

        public StudyYearsRepository(AppDbContext context)
        {
            _context = context;
        }

        public StudyYear Create(StudyYear studyYear)
        {
            _context.StudyYears.Add(studyYear);
            _context.SaveChanges();
            return _context.StudyYears.FirstOrDefault(s => s.Id == studyYear.Id);
        }

        public List<StudyYear> GetAll()
        {
            return _context.StudyYears.ToList();
        }

        public StudyYear GetStudyYearById(int id)
        {
            return _context.StudyYears.FirstOrDefault(s => s.Id == id);
        }
    }
}
