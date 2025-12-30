using System;
using System.Collections.Generic;
using System.Text;
using UserLogin.DAL;
using UserLogin.Models;

namespace UserLogin.Service
{
    public class UserServiceImpl : UserService
    {
        private readonly UserRepository repo;

        public UserServiceImpl(ApplicationDbContext context)
        {
            repo = UserRepositoryFactory.Create(RepositoryType.StoredProcedure,context);
        }

        public Users? ValidateUser(string? username, string? password)
        {
            return repo.ValidateUser(username, password);
        }

        public bool CreateUser(string? createUsername, string? createPassword, string? nameOfUser)
        {
            return repo.CreateUser(createUsername,createPassword,nameOfUser);
        }

        public bool DeleteUser(string? usernameToDelete)
        {
            return repo.DeleteUser(usernameToDelete);
        }

        public Users? UpdateUser(int id, string? updateUsername, string? updatePassword, string? updateName)
        {
            return repo.UpdateUser(id, updateUsername,updatePassword,updateName);
        }
    }
}
