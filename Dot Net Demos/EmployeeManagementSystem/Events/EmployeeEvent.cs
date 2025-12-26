using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Events
{
    internal class EmployeeEvent
    {
        public event Action<EmployeeEvent> EmployeeAdded;

        public void OnEmployeeAdd(Employee emp)
        {
            EmployeeAdded?.Invoke(emp);
        }
    }
}
