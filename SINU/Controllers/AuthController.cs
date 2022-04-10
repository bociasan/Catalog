using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.Repository;
using SINU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace SINU.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;

        public AuthController(IUsersRepository usersRepository, IMapper mapper)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO dto)
        {

            var registeredUser = usersRepository.Register(mapper.Map<User>(dto));
            if (registeredUser != null)
            {
                return Ok(mapper.Map<UserInfoDTO>(registeredUser));
            }
            else
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
