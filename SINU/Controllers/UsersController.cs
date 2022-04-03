using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SINU.DTO;
using SINU.Model;
using SINU.Repository;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;
        public UsersController(IUsersRepository usersRepository, IMapper mapper)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var usersList = usersRepository.GetAll();
            if (usersList.Count > 0)
            {
                //return Ok(usersList.ConvertAll(x => new UserInfoDTO(x)));
                return Ok(usersList.ConvertAll(x => mapper.Map<UserInfoDTO>(x)));
            }
            else
            {
                return NotFound(new { message = "Students not found." });
            }
        }

        [HttpPost]
        public IActionResult Create(UserInsertDTO userInsertDTO)
        {
            User user = mapper.Map<User>(userInsertDTO);

            user = usersRepository.Insert(user);
            if (user != null)
            {
                return Ok(mapper.Map<UserInfoDTO>(user));
                //return Ok(new UserInfoDTO(user));
            }
            else
            {
                return BadRequest(new { message = "Can't create user." });
            }
        }

    }
}
