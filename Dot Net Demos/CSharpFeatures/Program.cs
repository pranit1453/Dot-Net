using CSharpFeatures;
using CSharpFeatures.AnonymousMethod;
using CSharpFeatures.AutoProperties;
using CSharpFeatures.CollectionInitializer;
using CSharpFeatures.Delegate;
using CSharpFeatures.Lambda;
using CSharpFeatures.NullableDemo;
using CSharpFeatures.ObjectInitializer;


namespace CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partial class means split larger class across files... at runtime  ---> single class
            /*
             For partial to work:
             Same class name
             Same namespace
             Same access modifier
             Same assembly
             */
            CMath cmath = new CMath();
            Console.WriteLine($"Addition : {cmath.Add(5, 10)}");
            Console.WriteLine($"Multiplication : {cmath.Multiply(5, 10)}");

            Console.WriteLine("--------------------------------------------");
            // Nullable Class Demo

            NullableClass nd = new NullableClass(1010, "Pranit");
            Console.WriteLine(nd.ID());
            Console.WriteLine(nd.Name());

            Console.WriteLine("----------------------------------------------");

            //Object Initializer

            ObjectInitializerClass oi = new ObjectInitializerClass
            {
                Id = 1,
                Name = "Pranit",
                Description = "Developer"
            };

            Console.WriteLine($"ID : {oi.Id}");
            Console.WriteLine($"Name : {oi.Name}");
            Console.WriteLine($"Description : {oi.Description}");


            Console.WriteLine("----------------------------------------------");

            // Collection initializer

            List<CollectionInitializerClass> list = new List<CollectionInitializerClass>
            {
                new CollectionInitializerClass
                {
                    Id = 101,
                    Name="Pranav",
                    Description = "DevOps"
                },
                new CollectionInitializerClass
                {
                     Id = 102,
                     Name="Pratik",
                     Description = "Salesforce"
                },
                new CollectionInitializerClass
                {
                     Id = 103,
                     Name="Amar",
                     Description = "DevOps"
                }
            };

            foreach (var item in list)
            {
                Console.WriteLine($"ID : {item.Id}, Name : {item.Name}, Description : {item.Description}");
            }

            Console.WriteLine("---------------------------------------------------------");

            // Auto properties

            AutoPropertiesDemo apd = new AutoPropertiesDemo
            {
                ID = 11,
                Name = "Hriday",
                Description = "Tester"
            };

            Console.WriteLine($"ID : {apd.ID}");
            Console.WriteLine($"Name : {apd.Name}");
            Console.WriteLine($"Description : {apd.Description}");

            // Implicit Type (var) – Compiler Knows the Type
            /*
             var i = 100;         // int
             var name = "Hitesh"; // string
             var emp = new Emp(); // Emp
             */

            /* Rules
             Only local variables   
             Must be initialized
             Compile-time type resolution
             Cannot be method parameter or return type
             */

            Console.WriteLine("---------------------------------------------------------");

            // Anonymous type

            /* Rules
             Must use var
             Properties are read-only
             Cannot return from method (unless object)
             Same property names + order ⇒ same type
             */
            var emp = new
            {
                Eid = 101010,
                EName = "Ravi",
                ESal = 25000
            };
            Console.WriteLine($"ID : {emp.Eid}");
            Console.WriteLine($"Name : {emp.EName}");
            Console.WriteLine($"Salary : {emp.ESal}");

            Console.WriteLine("---------------------------------------------------------");

            // Anonymous Methods
            /* Purpose
             Inline logic
             Avoid writing separate methods
             Event handling
             Callbacks
             */

            AnonymousMethodDemo.MathOperations<int> add = (x, y) => x + y;

            int result = AnonymousMethodDemo.ExecuteOperation(10, 20, add);
            Console.WriteLine($"Result : {result}");

            AnonymousMethodDemo.MathOperations<int> multiply = (x, y) => x * y;

            int mul = AnonymousMethodDemo.ExecuteOperation(10,20,multiply);
            Console.WriteLine($"Result : {mul}");

            AnonymousMethodDemo.MathOperations<double> div = (x, y) => x / y;

            var divide = AnonymousMethodDemo.ExecuteOperation(5, 2, div);
            Console.WriteLine($"Result : {divide}");

            Console.WriteLine("---------------------------------------------------------");

            // Delegate : A delegate is a type-safe function pointer.
            // call delegate here
            MyDelegate<bool> check = (data1,data2) => data1 == data2;

            bool res = DelegateDemo.CheckMyDelegate<bool>(true, true, check);
            Console.WriteLine($"Result = {res}");

            MyDelegateBool<int> datacheck = (data1, data2) => data1 > data2;

            var res1 = DelegateDemo.CheckMyDelegateBool<int>(10, 20, datacheck);
            Console.WriteLine($"Result : {res1}");

            Console.WriteLine("-------------------------------------------------");

            // Calling with delegate and lambda

            Check<int> isEven = delegate (int data)
            {
                return data % 2 == 0;
            };

            // Lambda Expression
            Check<int> isEven1 = (data) => data % 2 == 0;

            bool even = CallingDemo.Checking<int>(10, isEven);
            Console.WriteLine($"Result is Even : {even}");

            bool even1 = CallingDemo.Checking<int>(11, isEven);
            Console.WriteLine($"Result is Even : {even1}");

            Check<int> isOdd = delegate (int data)
            {
                return data % 2 != 0;
            };

            // Lambda Expression
            Check<int> isOdd1 = (data) => data % 2 != 0;

            bool odd = CallingDemo.Checking<int>(21, isOdd);
            Console.WriteLine($"Result is Odd : {odd}");

            bool odd1 = CallingDemo.Checking<int>(20, isOdd);
            Console.WriteLine($"Result is Odd : {odd1}");

            int no = 9;
            Check<int> del = data => data > 10;
            bool status = CallingDemo.Checking<int>(no, del);
            if (status)
            {
                Console.WriteLine($"No : {no} is greater than 10");
            }
            else
            {
                Console.WriteLine($"No : {no} is NOT greater than 10");
            }
        }
    }
}
