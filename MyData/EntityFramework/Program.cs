using EntityFramework.DAL;
using EntityFramework.Models;


namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Student student = new Student
            {
                Name = "Pranit",
                Age = 22
            };
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Student Added");

            //read
            var students = context.Students.ToList();
            Console.WriteLine("\nAll Students : ");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Age})");
            }

            // Update

            var first = context.Students.First();
            first.Age = 23;
            context.SaveChanges();
            Console.WriteLine("\nStudent Updated");

            // Delete

            context.Students.Remove(first);
            context.SaveChanges();
            Console.WriteLine("\nStudent Deleted");
        }
    }
}
