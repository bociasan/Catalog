using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.Model;
using SINU.Repository;
using AutoMapper;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly ISubjectsProfesorRepository subjectsProfesorRepository;
        private readonly IGradesRepository gradesRepository;
        private readonly IStudentsRepository studentsRepository;
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;

        public GradesController(IGradesRepository gradesRepository, IUsersRepository usersRepository,
                                ISubjectsProfesorRepository subjectsProfesorRepository, 
                                IStudentsRepository studentsRepository, IMapper mapper )
        {
            this.subjectsProfesorRepository = subjectsProfesorRepository;
            this.studentsRepository = studentsRepository;
            this.gradesRepository = gradesRepository;
            this.usersRepository = usersRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            //var gradesList = gradesRepository.GetAll().ConvertAll(s => mapper.Map<GradeInfoDTO>(s));
            var gradesList = gradesRepository.GetAll().ConvertAll(s => mapper.Map<GradeInfoDTO>(s));

            if (gradesList.Count > 0)
            {
                return Ok(gradesList);
            }
            else
            {
                return NotFound(new { message = "Grades not found." });
            }
        }


        [HttpGet("/student/{id}")]
        public IActionResult GetGradesByStudentId(int id)
        {
            var gradesList = gradesRepository.GetGradesByStudentId(id).ConvertAll(s => mapper.Map<GradeInfoDTO>(s));
            if (gradesList != null)
            {
                return Ok(gradesList);
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound(new { message = $"Grades not found for StudentId {id} not found." });
            }
        }

        [HttpGet("/teacher/{id}")]
        public IActionResult GetGradesByProfessorId(int id)
        {
            var gradesList = gradesRepository.GetGradesByProfessorId(id).ConvertAll(s => mapper.Map<GradeInfoDTO>(s));
            if (gradesList != null)
            {
                return Ok(gradesList);
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound(new { message = $"Grades not found for ProfesorId {id}." });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetGradeById(int id)
        {
            var grade = gradesRepository.GetGradeById(id);
            if (grade != null)
            {
                return Ok(mapper.Map<GradeInfoDTO>(grade));
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound(new { message = $"Grade not found for Id {id}." });
            }
        }

        [HttpGet("{id}/Detailed")]
        public IActionResult GetGradeDetailedById(int id)
        {
            var grade = gradesRepository.GetGradeById(id);
            if (grade != null)
            {
                return Ok(mapper.Map<GradeInfoDetailedDTO>(grade));
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound(new { message = $"Grade not found for Id {id}." });
            }
        }
    }
}
