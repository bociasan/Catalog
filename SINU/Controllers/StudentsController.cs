using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.Model;
using SINU.Repository;





// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // GET: api/<StudentsController>
        [HttpGet]
        public List<Student> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _repository.GetStudentById(id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public IActionResult Post(StudentDTO dto)
        {
            var student = new Student()
            {
                ClassId = dto.ClassId,
                UserId = dto.UserId,
                StudyYearId = dto.StudyYearId
            };
            var newStudent = _repository.Create(student);
            if (newStudent != null)
            {
                return Ok(newStudent);
            }
            else
            {
                return BadRequest("Can't create this student.");
            }
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
