using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo_Interface
{
    internal class MathsOperations:Math1,Math2,Math3
    {
        public int add(int a,int b)
        {
            return a + b;
        }

        public int subtract(int a,int b)
        {
            return a - b;
        }

        public double div(int a,int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Denominator cannot be 0...");
            }
            else
            {
                return a / b;
            }
            return 0;
        }

        public int mul(int a,int b)
        {
            return a * b;
        }

        //public void log(string message)
        //{
        //    Console.WriteLine(message);
        //}
        void Math3.log(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
