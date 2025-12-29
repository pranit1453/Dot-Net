using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject.DAL
{
    public static class DBHelper
    {
        private static readonly string connectionString =
           "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";

        public static DataSet GetDataSet(string selectQuery, string tableName, SqlParameter[]? parameters = null)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();

            if (parameters == null)
            {
                SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da.Fill(ds, tableName);
            }
            else
            {
                using SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da.Fill(ds, tableName);
            }

            return ds;
        }


        public static int UpdateDataSet(string selectquery,DataSet ds, string tablename, SqlParameter[]? parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter;

                if (parameters != null)
                {
                    using SqlCommand cmd = new SqlCommand(selectquery, conn);
                    cmd.Parameters.AddRange(parameters);
                    adapter = new SqlDataAdapter(cmd);
                }
                else
                {
                    adapter = new SqlDataAdapter(selectquery, conn);
                }

                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                return adapter.Update(ds, tablename);
            }
        }
    }
}
