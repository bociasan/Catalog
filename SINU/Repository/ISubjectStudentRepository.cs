using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.Data;
using SINU.Model;

namespace SINU.Repository
{
    public interface ISubjectStudentRepository
    {
        SubjectStudent GetSubjectStudentById(int id);
        List<SubjectStudent> GetSubjectStudentBySubjectId(int id);
        List<SubjectStudent> GetAll();

        SubjectStudent Create(SubjectStudent subjectStudent);
    }
}