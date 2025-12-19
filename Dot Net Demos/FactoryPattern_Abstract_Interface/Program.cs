namespace FactoryPattern_Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report r1 = FactoryDesignClass.CreateReport("JSON");
            r1.generateReport();

            Report r2 = FactoryDesignClass.CreateReport("PDF");
            r2.generateReport();
        }
    }
}
