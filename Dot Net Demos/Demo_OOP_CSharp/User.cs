using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_CSharp
{
    internal class User
    {
        private int userID;
        private String username;
        private String password;

        public User()
        {
            this.userID = 0;
            this.username = "";
            this.password = "";
        }

        public User(int userID, string username, string password)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
        }

        public int UserId { get => userID; set => userID = value; }
        public string Uname { get => username; set => username = value; }
        public string Upass { get => password; set => password = value; }

        public override string ToString()
        {
            return $"UserId : {userID}, Username : {username}, Password : {password}.";
        }
    }
}
