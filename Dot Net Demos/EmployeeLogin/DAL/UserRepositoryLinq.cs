using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Models;

namespace UserLogin.DAL
{
    public class UserRepositoryLinq : UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepositoryLinq(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CreateUser(string? createUsername, string? createPassword, string? nameOfUser)
        {
            Users user = new Users
            {
                Username = createUsername,
                Password = createPassword,
                Name = nameOfUser
            };

            _context.user.Add(user);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteUser(string? usernameToDelete)
        {
            var user = _context.user.FirstOrDefault(u=>u.Username == usernameToDelete);
            if (user == null)
            {
                return false;
            }

            _context.user.Remove(user);
            return _context.SaveChanges() > 0;
        }

        public Users? UpdateUser(int id, string? updateUsername, string? updatePassword, string? updateName)
        {
            var user = _context.user.FirstOrDefault(u=> u.Id == id);
            if(user == null)
            {
                return null;
            }

            user.Username = updateUsername;
            user.Password = updatePassword;
            user.Name = updateName;

            _context.SaveChanges();
            return new Users
            {
                Id = user.Id,
                Username = user.Username,
                Name = user.Name
            };
        }

        public Users? ValidateUser(string? username, string? password)
        {
            return _context.user
                .Where(u => u.Username == username && u.Password == password)
                .Select(u => new Users
                {
                    Id = u.Id,
                    Username = u.Username,
                    Name = u.Name,
                }).FirstOrDefault();

        }
    }
}
