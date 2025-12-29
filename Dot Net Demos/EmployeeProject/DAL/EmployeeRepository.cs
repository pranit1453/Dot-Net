using EmployeeProject.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject.DAL
{
    public class EmployeeRepository
    {
        public List<Employee> GetAllData()
        {
            List<Employee> employees = new List<Employee>();

            string query = "SELECT * FROM Employee";
            DataSet ds = DBHelper.GetDataSet(query,"Employee");

            if (ds.Tables["Employee"] is DataTable table)
            {
                foreach (DataRow row in table.Rows)
                {
                    Employee e = new Employee
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        Address = row["Address"].ToString(),
                    };

                    employees.Add(e);
                }
            }  
            return employees;
        }

        public List<Employee> GetDataByName(string? name)
        {
            List<Employee> employees = new List<Employee>();
            string query = "Select Name From Employee Where Name = @Name";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name",name)
            };
            DataSet ds = DBHelper.GetDataSet(query, "Employee",parameters);

            if (ds.Tables["Employee"] is DataTable table)
            {
                foreach (DataRow row in table.Rows)
                {
                    Employee e = new Employee
                    {
                        Name = row["Name"].ToString()
                    };

                    employees.Add(e);
                }
            }
            return employees;
        }
    }
}
