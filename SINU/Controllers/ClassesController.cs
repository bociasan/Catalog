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
    public class ClassesController : ControllerBase
    {
        private readonly IClassesRepository classesRepository;
        private readonly ISubjectsClassRepository subjectsClassRepository;
        private readonly IStudentsRepository studentsRepository;
        private readonly IMapper mapper;

        public ClassesController(IClassesRepository classesRepository, ISubjectsClassRepository subjectsClassRepository, IStudentsRepository studentsRepository, IMapper mapper)
        {
            this.subjectsClassRepository = subjectsClassRepository;
            this.classesRepository = classesRepository;
            this.studentsRepository = studentsRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            var classesList = classesRepository.GetAll().ConvertAll(s => mapper.Map<ClassDTO>(s));
            if (classesList.Count > 0)
            {
                return Ok(classesList);
            }
            else
            {
                return NotFound("Classes not found.");
            }
        }

        [HttpGet("{classId}")]
        public IActionResult Get(int classId)
        {
            var existingClass = classesRepository.GetClassById(classId);
            if (existingClass != null)
            {
                return Ok(mapper.Map<ClassDTO>(existingClass));
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound($"Class with id {classId} not found." );
            }
        }

        [HttpGet("{classId}/Detailed")]
        public IActionResult GetDetailed(int classId)
        {
            var existingClass = classesRepository.GetClassById(classId);
            if (existingClass != null)
            {
                var classInfo = mapper.Map<ClassInfoDTO>(existingClass);
                var subjects = subjectsClassRepository.GetSubjectClassByClassId(classId);
                if (subjects != null)
                {
                    classInfo.Subjects = subjects.ConvertAll(s => mapper.Map<SubjectClassDTO>(s));
                    return Ok(classInfo);
                }
                else
                {
                    //return BadRequest("There is no subjects for ClassId = " + id);
                    return Ok(classInfo);
                }
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound($"Class with id {classId} not found.");
            }
        }

        [HttpGet("{classId}/Subjects")]
        public IActionResult GetSubjects(int classId)
        {

            if (classesRepository.GetClassById(classId) != null)
            {
                var subjects = subjectsClassRepository.GetSubjectClassByClassId(classId);
                if (subjects != null)
                {
                    return Ok(subjects.ConvertAll(s => mapper.Map<SubjectClassDTO>(s)));
                    //return Ok(mapper.Map<ClassInfoDTO>(subjects));
                }
                else
                {
                    return BadRequest("There is no subjects for ClassId = " + classId);
                }
            }
            else
            {
                return NotFound(new { message = $"Class with id {classId} not found." });
            }

            //var existingClass = classesRepository.GetClassById(id);
            //if (existingClass != null)
            //{
            //    var subjects = subjectsClassRepository.GetSubjectClassByClassId(id);
            //    //return Ok(mapper.Map<ClassInfoDTO>(existingClass));
            //    return Ok(subjects);
            //}
            //else
            //{
            //    //return BadRequest("There is no class with id = " + id);
            //    return NotFound(new { message = $"Class with id {id} not found." });
            //}
        }

        [HttpGet("{classId}/Students")]
        public IActionResult GetStudentsByClassId(int classId)
        {
            if (classesRepository.GetClassById(classId) != null)
            {
                var students = studentsRepository.GetStudentsByClassId(classId);
                if (students.Count > 0)
                {
                    return Ok(students.ConvertAll(s => mapper.Map<StudentDTO>(s)));
                }
                else
                {
                    //return BadRequest("There is no class with id = " + id);
                    return NotFound("No students in this class.");
                }
            } else
            {
                return NotFound($"Class with id {classId} not found.");
            }
        }
    }
}
