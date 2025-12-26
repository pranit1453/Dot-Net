using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Delegate
{
    internal class SalaryDelegate
    { 
        // Delegate to calculate Salary...
        public delegate double SalaryCalculator(double basic);
    }
}
