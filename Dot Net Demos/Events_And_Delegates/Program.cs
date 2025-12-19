using System.Text.Json.Serialization.Metadata;

namespace Events_And_Delegates
{
    // here we make a Delegate 
    public delegate void OperationsDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region old main
            //IMathOperation mo = new MathOperation();
            //// OpaerationsDelegate od = new OpaerationsDelegate(mo.add);

            //// here we couple our methods using delegate
            //// multicast delegate......
            //OpaerationsDelegate od = mo.add;
            //od += mo.divide;
            //od += mo.multiply;
            //// od += mo.subtract;

            //int res = mo.subtract(5, 2);

            //// here we decouple our methods using delegate
            ////od -= mo.add;

            //// here we invoke all the methods
            //od(10, 5); 
            #endregion

            MathOperation mo = MathOperationFactory.create();
            mo.PerformOperations(10, 5);

            int res = mo.subtract(10, 5);
            Console.WriteLine($"Result of (10,5) is : {res}");
        }
    }

    #region old interface
    //public interface IMathOperation
    //{
    //    public void add(int a, int b);
    //    public int subtract(int a, int b);
    //    public void multiply(int a, int b);
    //    public void divide(int a, int b);

    //} 
    #endregion
    #region without event
    //public class MathOperation : IMathOperation
    //{
    //    public void add(int a, int b)
    //    {
    //        Console.WriteLine($"{a} + {b} = {a + b}");
    //    }

    //    public void divide(int a, int b)
    //    {
    //        Console.WriteLine($"{a} / {b} = {a / b}");
    //    }

    //    public void multiply(int a, int b)
    //    {
    //        Console.WriteLine($"{a} * {b} = {a * b}");
    //    }

    //    public int subtract(int a, int b)
    //    {
    //        Console.WriteLine($"{a} - {b} = {a - b}");
    //        return a - b;
    //    }
    //} 
    #endregion


    public class MathOperationFactory
    {
        public static MathOperation create()
        {
            var mo = new MathOperation();
            // Subscribe once here
            mo.OnAdd += (a, b) => Console.WriteLine($"Event: {a} + {b} = {a + b}");
            mo.OnMultiply += (a, b) => Console.WriteLine($"Event: {a} - {b} = {a - b}");
            mo.OnDivide += (a, b) => Console.WriteLine($"Event: {a} / {b} = {a / b}");

            return mo;
        }
    }
    public interface IMathOperation
    {
        void PerformOperations(int a, int b);
        public int subtract(int a, int b);

    }
    public class MathOperation : IMathOperation
    {
        // here we declare events...
        public event OperationsDelegate? OnAdd;
        public event OperationsDelegate? OnMultiply;
        public event OperationsDelegate? OnDivide;

        public void PerformOperations(int a, int b)
        {
            // events raise........
            OnAdd?.Invoke(a, b);
            OnMultiply?.Invoke(a, b);
            OnDivide?.Invoke(a, b);
        }

        public int subtract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
            return a - b;
        }
    }
}
