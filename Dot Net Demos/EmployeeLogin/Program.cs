
using Microsoft.EntityFrameworkCore;
using UserLogin.DAL;
using UserLogin.Models;
using UserLogin.Service;

namespace EmployeeLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True")
                .Options;

            ApplicationDbContext context = new ApplicationDbContext(options);  
            UserService service = new UserServiceImpl(context);

            while (true)
            {
                Console.WriteLine("\n1. Login\n2. Create User\n3. Delete User\n4. Update User\n5. Exit");
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Username: ");
                        string? username = Console.ReadLine();
                        Console.Write("Password: ");
                        string? password = Console.ReadLine();

                        Users? user = service.ValidateUser(username, password);
                        Console.WriteLine(user != null
                            ? $"Welcome {user.Name}"
                            : "Invalid credentials!");
                        break;

                    case 2:
                        Console.WriteLine("Register User....");
                        Console.Write("Enter Username : ");
                        string? createUsername = Console.ReadLine();
                        Console.Write("Enter Password : ");
                        string? createPassword = Console.ReadLine();
                        Console.Write("Enter Name : ");
                        string? nameOfUser = Console.ReadLine();

                        var status = service.CreateUser(createUsername, createPassword, nameOfUser);
                        Console.WriteLine(status ? "Account Created Successfully. Go and Login " : "Account Already Exist. Go and Login");
                        break;

                    case 3:
                        Console.Write("Enter Username to delete: ");
                        string? usernameToDelete = Console.ReadLine();

                        var result = service.DeleteUser(usernameToDelete);
                        Console.WriteLine(result ? "Account Deleted Successfully." : "Username is incorrect");
                        break;

                    case 4:
                        Console.Write("Enter ID : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Update User Details....");
                        Console.Write("Enter Username to Update : ");
                        string? updateUsername = Console.ReadLine();
                        Console.Write("Enter Password to Update : ");
                        string? updatePassword = Console.ReadLine();
                        Console.Write("Enter Name to Update : ");
                        string? updateName = Console.ReadLine();

                        Users? updatedUser = service.UpdateUser(id, updateUsername, updatePassword, updateName);

                        Console.WriteLine(updatedUser != null
                            ? $"User Updated Successfully. New Name: {updatedUser.Name}"
                            : "Update Failed. Check the ID.");
                        break;
                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
