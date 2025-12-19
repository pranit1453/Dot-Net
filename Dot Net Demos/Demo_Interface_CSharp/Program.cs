using System.Runtime.Intrinsics.Arm;

namespace Demo_Interface_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface");
            Student s1 = new Student(101, "Rahul", 12, "rahul@gmail.com", "9876543210");
            StudentInfo sinfo = s1;
            ContactInfo cinfo = s1;

            sinfo.displayInfo();
            cinfo.contactInfo();
        }
    }
}
