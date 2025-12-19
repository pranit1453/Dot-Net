namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = EmployeeFactory.create();
            Employee emp1 = EmployeeFactory.create();
            Employee emp2 = EmployeeFactory.create();
        }
    }

    public class Employee
    {
        private int eid;
        private string ename;
        private string eadd;

        public string Eadd
        {
            get { return eadd; }
            set { eadd = value; }
        }

        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }

    }

    public class EmployeeFactory
    {
        public static Employee create()
        {
            var emp = new Employee();
            emp.Eid = 1;
            emp.Ename = "Raj";
            emp.Eadd = "India";

            var emp1 = new Employee();
            emp1.Eid = 101;
            emp1.Ename = "Hugh Jackman";
            emp1.Eadd = "Sydney, Australia";

            var emp2 = new Employee();
            emp2.Eid = 102;
            emp2.Ename = "Tony Stark";
            emp2.Eadd = "Shivaji Nagar";

            return emp;
        }
    }


}
