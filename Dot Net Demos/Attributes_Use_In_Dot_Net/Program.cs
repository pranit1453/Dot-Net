using System.Reflection;

namespace Attributes_Use_In_Dot_Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Type type=typeof(Employee);
            BonaventureSystemAttribute? attribute = 
                type.GetCustomAttribute<BonaventureSystemAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Company Name : {attribute.CompanyName}");
                Console.WriteLine($"Developer Name : {attribute.DeveloperName}");
            }
        }
    }

    // BonaventureSystemsAttribute is a custom metadata tag that you can attach to a class.

    [AttributeUsage(AttributeTargets.Class)]
    public class BonaventureSystemAttribute : Attribute
    {
        private string _CompanyName;
        private string _DeveloperName;

        public BonaventureSystemAttribute(string companyName, string developerName)
        {
            this._CompanyName = companyName;
            this._DeveloperName = developerName;
        }
        public string DeveloperName
        {
            get { return _DeveloperName; }
            set { _DeveloperName = value; }
        }

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

    }

    [BonaventureSystem("Bonaventure Systems", "Pranit")]
    public class Employee
    {
        private int _Eid;
        private string _Ename;

        public Employee(int Eid,string Ename)
        {
            this._Eid = Eid;
            this._Ename = Ename;
        }
        public int Eid
        {
            get { return _Eid; }
            set { _Eid = value; }
        }
        public string MyProerty
        {
            get { return _Ename; }
            set { _Ename = value; }
        }

    }
}
