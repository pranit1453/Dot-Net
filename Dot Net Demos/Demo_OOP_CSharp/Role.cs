using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_CSharp
{
    internal class Role:User
    {
        private String role;

        public Role()
        {
            this.role = "";
        }

        public Role(int userID, string username, string password,String role) : base(userID, username, password)
        {
            this.role = role;
        }

        public string RoleName { get => role; set => role = value; }

        public override string ToString()
        {
            return base.ToString()+$" Role : {role}";
        }
    }
}
