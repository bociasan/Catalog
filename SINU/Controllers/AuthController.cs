using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
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

        private readonly IUsersRepository usersRepository;

        public AuthController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

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

            if (usersRepository.Register(user) !=null)
            {
                return Ok("success");
            } else
            {
                return BadRequest("something went wrong on registering. (User not found)");
            }
        }


        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            var user = usersRepository.GetUserByEmail(dto.Email);
            if (user == null) return NotFound(new { message = $"User with email {dto.Email} not found." });
            if (user.Password != dto.Password) return BadRequest(new { message = "Incorrect password." });
            return Ok(user);
        }
    }
}
