using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerilaizable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\250845920054\MS Dot Net\MS Dot Net\BinarySerilaizable\Data File\empdata.txt";

            
            Emp emp = new Emp();
            emp.Eid = 1;
            emp.Ename = "Pranit";
            emp.Password = "pass123";

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, emp);
            }

            Console.WriteLine("Binary Serialization Done...");

            Emp empData;
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                empData = (Emp)bf.Deserialize(fs);
            }

            Console.WriteLine("Binary Deserialization Done...");
            Console.WriteLine($"Id = {empData.Eid}, Name = {empData.Ename}, Password = {empData.Password}");

            Console.ReadLine();
        }
    }
    [Serializable]
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
                return ename ?? "Name is null";
            }
            set { ename = value; }
        }

        public string Password
        {
            get
            {
                return password ?? "Password is null";
            }
            set { password = value; }
        }
    }
}
