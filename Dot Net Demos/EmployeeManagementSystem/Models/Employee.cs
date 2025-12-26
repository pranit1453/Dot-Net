using EmployeeManagementSystem.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    [Log] // Custom Attribute
    internal class Employee
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public double salary {  get; set; }
        public string ?Department {  get; set; }
    }
}
