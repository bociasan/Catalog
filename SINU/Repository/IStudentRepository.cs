using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.Controllers;
using SINU.Model;

namespace SINU.Repository { 
    public interface IStudentRepository
    {
        Student GetStudentById(int id);
        List<Student> GetAll();
   
        Student Create(Student student);
    }
}
