using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.Model;

namespace SINU.Repository { 
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        User GetUserByUsername(string Username);
        User Register(User user);
        List<User> GetAll();
    }
}
