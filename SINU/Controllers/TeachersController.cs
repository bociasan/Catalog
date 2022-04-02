using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.Model;
using SINU.Repository;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepository _repository;

        public TeachersController(ITeacherRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Teacher> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return _repository.GetTeacherById(id);
        }

        [HttpGet("{id}/materials")]
        public List<SubjectProfesor> GetTeacherMaterials(int id)
        {
            return _repository.GetTeacherSubjectsByTeacherId(id);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Teacher teacher)
        {
            teacher.Id = id;
            var newTeacher = _repository.Update(teacher);
            if (newTeacher != null)
            {
                return Ok(newTeacher);
            }
            else
            {
                return BadRequest("Can't create this teacher.");
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
