using System;
using System.Collections.Generic;
using System.Text;
using UserLogin.Models;

namespace UserLogin.DAL
{
    public interface UserRepository
    {
        bool CreateUser(string? createUsername, string? createPassword, string? nameOfUser);
        bool DeleteUser(string? usernameToDelete);
        Users? UpdateUser(int id, string? updateUsername, string? updatePassword, string? updateName);
        Users? ValidateUser(string? username, string? password);
    }
}
