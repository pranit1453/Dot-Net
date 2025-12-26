using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.Lambda
{
    public delegate bool Check<T>(T data);

    public class CallingDemo
    {

        public static bool Checking<T>(T data, Check<T> res)
        {
            return res(data);
        }
            
    }
}
