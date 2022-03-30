using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.DTO.LoginDTO;
using SINU.Repository;
using SINU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SINU.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUserRepository _repository;

        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }


        //[HttpGet]
        //public List<User> GetAll()
        //{
        //    return _repository.GetAll();
        //}

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO dto)
        {
            var user = new User
            {

                IDNP = dto.IDNP,
                Username = dto.Username,
                Password = dto.Password,
                Email = dto.Email
            };

            if (_repository.Register(user) !=null)
            {
                return Ok("success");
            } else
            {
                return BadRequest("something went wrong on registering.");
            }



            

        }


        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {

            var user = _repository.GetUserByEmail(dto.Email);
            if (user == null) return NotFound(new { message = $"User with email {dto.Email} not found." });

            if (user.Password != dto.Password) return BadRequest(new { message = "Incorrect password." });

            return Ok(user);

        }

    }
}
