using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using UserLogin.Models;

namespace UserLogin.DAL
{
    public class UserRepositoryImpl : UserRepository
    {
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
            
            if(row == null)
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

        public bool CreateUser(string? createUsername, string? createPassword, string? nameOfUser)
        {
            string query = @"INSERT INTO Users (Username,Password,Name) VALUES (@Username, @Password, @Name)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Username",createUsername),
                new SqlParameter("@Password",createPassword),
                new SqlParameter("@Name",nameOfUser)
            };

            var userDetails = DBHelper.ExecuteNonQuery(query, parameters);
            return userDetails > 0;

        }

        public bool DeleteUser(string? usernameToDelete)
        {
            string query = @"DELETE FROM Users WHERE Username = @Username";

            SqlParameter[] parameter =
            {
                new SqlParameter("@Username",usernameToDelete)
            };

            var deletedUser = DBHelper.ExecuteNonQuery(query, parameter);
            return deletedUser > 0;
        }

        public Users? UpdateUser(int id, string? updateUsername, string? updatePassword, string? updateName)
        {
            string query = @"UPDATE Users SET Username = @Username, Password = @Password ,Name = @Name WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Username",updateUsername),
                new SqlParameter("@Password",updatePassword),
                new SqlParameter("@Name",updateName),
                new SqlParameter("@Id",id)
            };

            int rowsAffected = DBHelper.ExecuteNonQuery(query,parameters);
            if (rowsAffected <= 0) return null;
            
                string sql = @"SELECT Id, Username, Name FROM Users WHERE Id = @Id";
                SqlParameter[] parameters1 =
                {
                    new SqlParameter("@Id",id)
                };

                var updateData = DBHelper.ExecuteSelect(sql, parameters1);
                var row = updateData.FirstOrDefault();
                if (row == null) return null;

                return new Users
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Username = row["Username"]?.ToString(),
                    Name = row["Name"]?.ToString()
                };
        }
    }
}
