using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.Model;
using SINU.Repository;
using SINU.DTO;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _repository.GetStudentById(id);
        }

        //[HttpPost]
        //public IActionResult Post(StudentDTO dto)
        //{
        //    var student = new Student()
        //    {
        //        ClassId = dto.ClassId,
        //        UserId = dto.UserId,
        //        StudyYearId = dto.StudyYearId
        //    };
        //    var newStudent = _repository.Create(student);
        //    if (newStudent != null)
        //    {
        //        return Ok(newStudent);
        //    }
        //    else
        //    {
        //        return BadRequest("Can't create this student.");
        //    }
        //}
    }
}
