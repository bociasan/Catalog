using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.Model;
using SINU.Repository;
using SINU.VM;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ISubjectsProfesorRepository subjectsProfesorRepository;
        private readonly IUsersRepository usersRepository;
        private readonly ISubjectsRepository subjectsRepository;


        public TeachersController(ISubjectsProfesorRepository subjectsProfesorRepository, IUsersRepository usersRepository, ISubjectsRepository subjectsRepository)
        {
            this.subjectsProfesorRepository = subjectsProfesorRepository;
            this.usersRepository = usersRepository;
            this.subjectsRepository = subjectsRepository;
        }

        [HttpGet]
        public List<TeacherVM> Get()
        {
            //var teachers = usersRepository.GetTeachers();
            return usersRepository.GetTeachers().ConvertAll(x => new TeacherVM(x));
        }

        [HttpGet("{id}")]
        public TeacherVM Get(int id)
        {
            return new TeacherVM(usersRepository.GetUserById(id));
        }

        [HttpGet("{id}/materials")]
        public List<SubjectProfesorVM> GetTeacherMaterials(int id)
        {
            return subjectsProfesorRepository.GetSubjectsProfesorByTeacherId(id).ConvertAll(x => new SubjectProfesorVM(x));
        }

        //[HttpPut("{id}")]
        //public IActionResult Put(int id, TeacherVM teacherVM)
        //{
        //    var existingUser = usersRepository.GetUserById(id);    
        //    var newTeacher = subjectsProfesorRepository.Update(teacher);
        //    if (newTeacher != null)
        //    {
        //        return Ok(newTeacher);
        //    }
        //    else
        //    {
        //        return BadRequest("Can't update this teacher.");
        //    }
        //}
    }
}
