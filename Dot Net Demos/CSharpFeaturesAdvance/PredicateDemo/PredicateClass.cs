using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesAdvance.PredicateDemo
{
    public class PredicateClass
    {
        Predicate<int> del = num => num > 10;
        public void result()
        {
            Console.WriteLine($"Del Result is : {del(15)}");
        }
    }
}
