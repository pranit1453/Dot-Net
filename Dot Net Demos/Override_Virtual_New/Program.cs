namespace Override_Virtual_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Derived d = new Derived();
            Base b1 = new Derived();

            Console.WriteLine(" Base b = new Base();");
            b.virtualProp();
            b.normalProp();
            Console.WriteLine("===============================");

            Console.WriteLine(" Derived d = new Derived();");
            d.virtualProp();
            d.normalProp();
            Console.WriteLine("===============================");

            Console.WriteLine("Base b1 = new Derived();");
            b1.virtualProp();
            b1.normalProp();
            Console.WriteLine("===============================");

            /*
             Because new only hides the base member. The compiler
             resolves the call based on the reference type is of Base class,
             not the runtime type. So the derived version is ignored here.
             */

        }
    }
}
