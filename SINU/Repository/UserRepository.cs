using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.Data;
using SINU.Repository;
using SINU.Model;
using SINU.DTO;

namespace SINU.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

      public  UserRepository(AppDbContext context) {

            _context = context;
        
        }

        public User Register(RegisterDTO registerDTO)
        {

            var existingUser = _context.Users.FirstOrDefault(u => u.IDNP == registerDTO.IDNP);
            if (existingUser == null)
            {
                return null;
            } else
            {
                existingUser.Email = registerDTO.Email;
                existingUser.Password = registerDTO.Password;
                existingUser.Username = registerDTO.Username;
                _context.Users.Update(existingUser);
                _context.SaveChanges();
                return existingUser;
            }
        }

        public User Register(User user)
        {

            var existingUser = _context.Users.FirstOrDefault(u => u.IDNP == user.IDNP);
            if (existingUser == null)
            {
                return null;
            }
            else
            {
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Username = user.Username;
                _context.Users.Update(existingUser);
                _context.SaveChanges();
                return existingUser;
            }
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetUserByEmail(string Email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == Email);
        }

        public User GetUserByUsername(string Username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == Username);
        }
    }
}
