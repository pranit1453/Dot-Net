using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Basics_Datatypes
{
    internal class Datatypes
    {
        int a = 10;
        int b = 20;
        double c = 30.01;
        long d = 2599985555556222222;
        char e = 'a';
        string str = "Pranit";
        bool isCompleted = true;
        short s = 24545;

       public void result()
        {
            Console.WriteLine("Value of int a is {0}, Value of (System.Int32 b) is {1}," +
                " Value of double c is {2}, Value of long d is {3}, Value of char e is {4}, Value of String str is {5}," +
                "Value of bool is Completed is {6}, Value od Short s is{7}",a,b,c,d,e,str,isCompleted,s);
        }
    }
}
