using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesAdvance.ExtensionMethods
{
    public class WhereClass
    {
        //IEnumerable Works on any collection
        //Predicate<T> A method that returns bool
        public static IEnumerable<T> MyWhere<T>(IEnumerable<T> source, Predicate<T> condition)
        {
            foreach (var item in source)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> MyWhereWithFunc<T>(IEnumerable<T> source, Func<T, bool> condition)
        {
            foreach (var item in source)
            {
                if (condition(item))
                {
                    yield return item;  
                }
            }
        }
    }
}
/*
     Feature                Predicate<T>    	        Func<T, bool>

    Delegate type	        Specialized	                Generic
    Return type	            Always bool	                Any type
    Parameters	            Exactly 1	                0–16
    Used by LINQ	        No	                        Yes
    Extensibility	        Limited	                    Very flexible
    Modern C# usage	        Older	                    Preferred 

    public delegate bool Predicate<T>(T obj);
    public delegate TResult Func<T, TResult>(T arg);

*/
