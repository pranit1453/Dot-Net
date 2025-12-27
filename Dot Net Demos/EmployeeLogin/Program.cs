using EmployeeLogin.Models;
using EmployeeLogin.Service;

namespace EmployeeLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService service = new UserServiceImpl();
            while(true)
            {
                Console.WriteLine("1. Login \n2. Create User \n3. Delete User \n4. Modify User \n");
                Console.Write("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Username : ");
                        string? username = Console.ReadLine();
                        Console.Write("Enter Password : ");
                        string? password = Console.ReadLine();

                        User user = service.ValidateUser(username, password);
                        if(user != null)
                        {
                            Console.WriteLine($"Welcome, {user.Name}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials!!!");
                        }
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
