using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.Model;
using SINU.Repository;





// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassRepository _repository;

        public ClassesController(IClassRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public List<Class> Get()
        {
            return _repository.GetAll();
        }


        [HttpGet("{id}")]
        public Class Get(int id)
        {
            return _repository.GetClassById(id);
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
