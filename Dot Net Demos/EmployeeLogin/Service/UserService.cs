using EmployeeLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogin.Service
{
    public interface UserService
    {
        User ValidateUser(string? username, string? password);
    }
}
