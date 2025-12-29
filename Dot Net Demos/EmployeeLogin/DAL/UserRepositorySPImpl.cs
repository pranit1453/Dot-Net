using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Models;

namespace UserLogin.DAL
{
    public class UserRepositorySPImpl : UserRepository
    {
        public bool CreateUser(string? createUsername, string? createPassword, string? nameOfUser)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username",createUsername),
                new SqlParameter("@Password",createPassword),
                new SqlParameter("@Name",nameOfUser)
            };

            var createUser = DBHelper.ExecuteSelect("Register_User",CommandType.StoredProcedure, parameters);

            int status = Convert.ToInt32(createUser.First()["Status"]);
            return status == 1;
        }

        public bool DeleteUser(string? usernameToDelete)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username",usernameToDelete)
            };

            var deleteUser = DBHelper.ExecuteSelect("Delete_User", CommandType.StoredProcedure, parameters);

            int status = Convert.ToInt32(deleteUser.First()["Status"]);

            return status == 1;
        }

        public Users? UpdateUser(int id, string? updateUsername, string? updatePassword, string? updateName)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username",updateUsername),
                new SqlParameter("@Password",updatePassword),
                new SqlParameter("@Name",updateName),
                new SqlParameter("@Id",id)
            };

            var updateUser = DBHelper.ExecuteSelect("Update_User", CommandType.StoredProcedure, parameters);

            var row = updateUser.First();
            if (row == null) return null;

            return new Users
            {
                Id = Convert.ToInt32(row["Id"]),
                Username = row["Name"].ToString(),
                Name = row["Name"].ToString(),
            };
        }

        public Users? ValidateUser(string? username, string? password)
        {
            string query = @"SELECT * FROM Users WHERE Username = @username AND Password = @password";

            SqlParameter[] parameters =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            var validate = DBHelper.ExecuteSelect(query, parameters);

            var row = validate.FirstOrDefault();

            if (row == null)
            {
                return null;
            }
            return new Users
            {
                Id = Convert.ToInt32(row["Id"]),
                Username = row["Username"]?.ToString(),
                Name = row["Name"]?.ToString()
            };
        }

    }
}
