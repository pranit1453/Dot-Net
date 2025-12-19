namespace Demo_OOP_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Role admin = new Role(1, "Ravi", "ravi123", "Administrator");
                Console.WriteLine(admin.ToString());

                Role guest = new Role(2, "Pravin", "pravin123", "Guest");
                Console.WriteLine(guest.ToString());
            
        }
    }
}
