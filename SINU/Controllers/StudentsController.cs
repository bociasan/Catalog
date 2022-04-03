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
        private readonly IStudentsRepository studentsRepository;

        public StudentsController(IStudentsRepository studentsRepository)
        {
            this.studentsRepository = studentsRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var studentsDTOList = studentsRepository.GetAll();
            if (studentsDTOList.Count > 0)
            {
                return Ok(studentsDTOList);
            }
            else
            {
                //return BadRequest("There are no students.");
                return NotFound(new { message = "Students not found." });
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var student = studentsRepository.GetStudentById(id);
            if (student != null)
            {
                return Ok(new StudentDTO(student));
            }
            else
            {
                //return BadRequest("There is no student with id = " + id);
                return NotFound(new { message = $"Student with id {id} not found." });

            }
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
