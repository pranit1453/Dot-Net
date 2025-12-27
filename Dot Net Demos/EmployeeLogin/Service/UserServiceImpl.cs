using EmployeeLogin.DAL;
using EmployeeLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.Service
{
    public class UserServiceImpl : UserService
    {
        private readonly UserRepository repo;

        public UserServiceImpl()
        {
            repo = new UserRepositoryImpl();
        }
        public User ValidateUser(string? username, string? password)
        {
            return repo.ValidateUser(username,password);
        }
    }
}
