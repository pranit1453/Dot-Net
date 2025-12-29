using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UserLogin.DAL
{
    public static class DBHelper
    {
        private static readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            " Initial Catalog=Test;" +
            "Integrated Security=True";

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Database operation failed", ex);
            }
        }
        
        public static List<Dictionary<string,object>> ExecuteSelect(
            string query, SqlParameter[] parameters)
        {
            try
            {
                var result = new List<Dictionary<string, object>>();

                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            /*
                             Dictionary represents one row
                             Key → Column name
                             Value → Column value
                             */
                            var row = new Dictionary<string, object>();
                            // reader.FieldCount = Number of columns
                            // Enumerable.Range(0, reader.FieldCount) → Generates column indexes
                            // Example: 0,1,2
                            foreach (var column in Enumerable.Range(0, reader.FieldCount))
                            {
                                /*
                                 reader.GetName(column) → Column name (e.g. "Username")
                                 reader.GetValue(column) → Column value (e.g. "pranit")
                                 */
                                row[reader.GetName(column)] = reader.GetValue(column);
                            }
                            result.Add(row);
                        }

                        return result;
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Database operation failed", ex);
            }
            
        }
        /*
         Use ExecuteNonQuery only if your SP doesn’t return any result,
         e.g., a plain DELETE that doesn’t return a status.
         */
        public static List<Dictionary<string,Object>> ExecuteSelect(string query, CommandType commandType , SqlParameter[] parameters)
        {
            try
            {
                var result = new List<Dictionary<string, Object>>();

                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = commandType;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string,Object>();

                            foreach (var column in Enumerable.Range(0,reader.FieldCount))
                            {
                                row[reader.GetName(column)] = reader.GetValue(column);
                            }
                            result.Add(row);
                        }
                        return result;
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Database operation failed", ex);
            }
            
        }
       
    }
}
