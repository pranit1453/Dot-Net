using System.Runtime.Serialization.Formatters.Binary;

namespace File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\250845920054\MS Dot Net\MS Dot Net\File_Handling\File Data\data.txt";



            // Stream Writer

            FileStream fs = null;
            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Hello.......");
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("Done.");

            

            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!!");
            }

            StreamReader reader = new StreamReader(fs);
            string content = reader.ReadToEnd();
            reader.Close();
            fs.Close();
            Console.WriteLine(content);
        }
    }

   
}
