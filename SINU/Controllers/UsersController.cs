using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SINU.Model;
using SINU.Repository;

namespace SINU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        [HttpGet]
        public List<User> GetAll()
        {
            return usersRepository.GetAll();
        }
    }
}
