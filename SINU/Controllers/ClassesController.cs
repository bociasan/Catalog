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
        private readonly IMapper mapper;

        public ClassesController(IClassesRepository classesRepository, IMapper mapper)
        {
            this.classesRepository = classesRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            var classesList = classesRepository.GetAll().ConvertAll(s=>mapper.Map<ClassDTO>(s));
            if (classesList.Count > 0)
            {
                return Ok(classesList);
            }
            else
            {
                return NotFound(new { message = "Classes not found." });
            }
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var existingClass = classesRepository.GetClassById(id);
            if (existingClass != null)
            {
                return Ok(mapper.Map<ClassDTO>(existingClass));
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound(new { message = $"Class with id {id} not found." });
            }
        }
    }
}
