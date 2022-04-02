using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
        public List<Class> Get()
        {
            return classesRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Class Get(int id)
        {
            return classesRepository.GetClassById(id);
        }
    }
}
