using EmployeeProject.DAL;

namespace EmployeeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();

            
            Console.WriteLine("All Employees:");
            var allEmployees = repository.GetAllData();
            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            }

            Console.WriteLine("\n-----------------------\n");

           
            Console.Write("Enter name to search: ");
            string? nameToSearch = Console.ReadLine();

            var employeesByName = repository.GetDataByName(nameToSearch);

            if (employeesByName.Count > 0)
            {
                Console.WriteLine($"\nEmployees with name '{nameToSearch}':");
                foreach (var emp in employeesByName)
                {
                    Console.WriteLine($"Name: {emp.Name}");
                }
            }
            else
            {
                Console.WriteLine($"No employees found with name '{nameToSearch}'.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
