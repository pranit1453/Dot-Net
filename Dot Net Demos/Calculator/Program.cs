using ClassTemplateLibrary;
using Math = ClassTemplateLibrary.Math;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mo = new MathOperation();
            mo.add(10, 20);

            MyMath mm = new MyMath();
            mm.wrapper();

            Math m = new Math();
            m.Math_Wrapper();
        }
    }

    public class MyMath : MathOperation
    {
        public void wrapper()
        {
            Console.WriteLine("Wrapper Result Add,mul,mod.....");
            base.add(2, 2);
            base.mul(4, 2);
            base.mod(10, 3);
        }

        public void multiply (int a,int b)
        {
            Console.WriteLine("Multiply Result Mul.....");
            base.mul(10, 2);
        }
    }
}
