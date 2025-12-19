namespace _00Demo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit & Explicit...............");
            MathsOperations m = new MathsOperations();
            Console.WriteLine(m.add(5, 4));
            Console.WriteLine(m.subtract(5, 4));
            Console.WriteLine(m.div(5, 0));
            Console.WriteLine(m.mul(5, 2));
            Console.WriteLine(m.div(10, 5));

            Math3 m3 = new MathsOperations();
            m3.log("Logs....");
        }
    }
}
