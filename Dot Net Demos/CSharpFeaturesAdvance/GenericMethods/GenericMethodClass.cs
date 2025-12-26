using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesAdvance.GenericMethods
{
    public class GenericMethodClass
    {
        // One method works for multiple data types.
        public static T MySum<T>(IEnumerable<T> arr) // Accepts any collection that implements IEnumerable<T>
        {
            /*
             dynamic bypasses compile-time type checking. 
             You must ensure the operation + is valid for the type T.
             */
            dynamic sum = 0; // The type is determined at runtime.
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
