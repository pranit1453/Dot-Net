namespace FactoryPatternPractice
{
    /*
     to limit the accessibility of 
     types or members (like classes, methods, and properties) 
     to within the current assembly
     */
    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("Enter Type : ");
                string type = Console.ReadLine() ?? string.Empty; // ?? null-coalescing operator

                BaseReport br = FactoryReport.BaseFactoryReport(type);
                br.GenerateReport();

                Console.WriteLine("Do you want to continue? (y/n) : ");
                string ans = Console.ReadLine() ?? string.Empty;

                if(ans == "n")
                {
                    break;
                }
            }

        }
    }
}
