using CSharpFeaturesAdvance.ExtensionMethods;
using CSharpFeaturesAdvance.GenericMethods;
using CSharpFeaturesAdvance.PredicateDemo;

namespace CSharpFeaturesAdvance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PredicateClass pc = new PredicateClass();
            pc.result();

            Console.WriteLine("------------------------------");

            int[] arr = { 1, 2, 3 };
            Console.WriteLine($"Result is : {GenericMethodClass.MySum(arr)}");

            Console.WriteLine("------------------------------");

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultByMyWhere= WhereClass.MyWhere(nums, n => n % 2 == 0);

            var resultByMyWhereFunc = WhereClass.MyWhereWithFunc(nums, n => n % 2 == 0);

            Console.WriteLine("Result using Predicate:");

            foreach (var item in resultByMyWhere)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\nResult using Func:");

            foreach (var item in resultByMyWhereFunc)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
