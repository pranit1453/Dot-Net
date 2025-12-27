using DatabaseConnectivityEfficiently.Database;
using Microsoft.Data.SqlClient;

namespace DatabaseConnectivityEfficiently
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Select \n2. Insert \n3. Update \n4. Delete \n");
                Console.Write("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        string query = "SELECT * FROM EMPLOYEE";
                        DBHelper.ExecuteSelect(query);
                        break;
                    case 2:
                        Console.Write("Enter Name : ");
                        string? name = Console.ReadLine();
                        Console.Write("Enter Address : ");
                        string? address = Console.ReadLine();

                        query = "INSERT INTO EMPLOYEE (Name,Address) VALUES (@Name,@Address)";

                        SqlParameter[] parameters1 =
                        {
                            new SqlParameter("@Name", name),
                            new SqlParameter("@Address", address),
                        };

                        int insert = DBHelper.ExecuteNonQuery(query, parameters1);

                        Console.WriteLine(insert > 0 ? "Inserted Successfully" : "Error");
                        break;
                    case 3:
                        Console.Write("Enter Id to Modify Data :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name to Update : ");
                        string? nameToUpdate = Console.ReadLine();
                        Console.Write("Enter Address to Update : ");
                        string? addressToUpdate = Console.ReadLine();

                        query = "UPDATE EMPLOYEE SET Name = @Name, Address = @Address WHERE Id = @Id";
                        SqlParameter[] parameters2 =
                        {
                            new SqlParameter ("@Name",nameToUpdate),
                            new SqlParameter("@Address",addressToUpdate),
                            new SqlParameter("@Id",id)
                        };

                        int update = DBHelper.ExecuteNonQuery(query,parameters2);
                        Console.WriteLine(update>0 ? "Updated Successfully" : "Error");
                        break;
                    case 4:
                        Console.Write("Enter Id to delete :");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());

                        query = "DELETE FROM EMPLOYEE WHERE Id = @Id";
                        SqlParameter[] parameters3 = {
                            new SqlParameter("@Id",idToDelete)
                        };

                        int delete = DBHelper.ExecuteNonQuery(query, parameters3);
                        Console.WriteLine(delete > 0 ? "Deleted Successfully" : "Error");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want continue? y/n");
                string? ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}
