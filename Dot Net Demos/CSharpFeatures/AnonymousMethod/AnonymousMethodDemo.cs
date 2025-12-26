using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.AnonymousMethod
{
    
    public class AnonymousMethodDemo
    {
        public delegate T MathOperations<T>(T a, T b);

        public static T ExecuteOperation<T>(T a,T b, MathOperations<T> operations)
        {
            return operations(a, b);
        }
    }
}
