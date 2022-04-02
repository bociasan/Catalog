﻿using System.Collections.Generic;
using SINU.Model;

namespace SINU.Repository
{
    public interface ISubjectsClassRepository
    {
        SubjectClass GetSubjectClassById(int id);
        List<SubjectClass> GetAll();

        SubjectClass Create(SubjectClass subjectClass);
    }
}