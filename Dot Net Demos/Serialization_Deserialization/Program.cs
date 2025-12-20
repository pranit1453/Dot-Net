using System.Text.Json;

namespace Serialization_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\250845920054\MS Dot Net\MS Dot Net\Serialization_Deserialization\Data File\data.json";
            Emp emp = new Emp
            {
                Eid = 1,
                Ename = "Pranit",
                Password = "pass123"
            };

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fs, emp);
            }

            Console.WriteLine("Serialization Done...");

            Emp? empData;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                empData = JsonSerializer.Deserialize<Emp>(fs);
            }

            if (empData != null)
            {
                Console.WriteLine("Deserialization Done...");
                Console.WriteLine($"Id       : {empData.Eid}");
                Console.WriteLine($"Name     : {empData.Ename ?? "Name is null"}");
                Console.WriteLine($"Password : {empData.Password ?? "Password is null"}");
            }
            else
            {
                Console.WriteLine("Failed to deserialize data.");
            }

            Console.ReadLine();
        }
    }
    public class Emp
    {
        private int eid;
        private string? ename;
        private string? password;

        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }

        public string Ename
        {
            get
            {
                if (ename == null)
                {
                    return "Name is null";
                }
                else
                    return ename;
            }
            set { ename = value; }
        }

        public string Password
        {
            get
            {
                if (password == null)
                {
                    return "Password is null";
                }
                return password;
            }
            set { password = value; }
        }
    }
}
