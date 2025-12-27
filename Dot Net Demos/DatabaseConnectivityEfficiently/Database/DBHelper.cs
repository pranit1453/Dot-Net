using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivityEfficiently.Database
{
    public static class DBHelper
    {
        private static string connectionString =
             "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            " Initial Catalog=Test;" +
            "Integrated Security=True";

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            using(SqlCommand cmd = new SqlCommand(query,conn))
            {
                if(parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            } // When the code exits this block, connection.Dispose() is called automatically
        }

        public static void ExecuteSelect(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using(SqlCommand cmd = new SqlCommand(query,conn))
            {
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine(
                            $"ID : {reader["Id"]}, Name : {reader["Name"]}, Address : {reader["Address"]}"
                            );
                    }
                }
            }
        }
    }
}
