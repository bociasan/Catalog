using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.Model;
using SINU.Repository;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassesRepository classesRepository;

        public ClassesController(IClassesRepository classesRepository)
        {
            this.classesRepository = classesRepository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {

            var classesDTOList = classesRepository.GetAll();
            if (classesDTOList.Count > 0)
            {
                return Ok(classesDTOList);
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
                return Ok(new ClassDTO(existingClass));
            }
            else
            {
                //return BadRequest("There is no class with id = " + id);
                return NotFound(new { message = $"Class with id {id} not found." });
            }
        }
    }
}
