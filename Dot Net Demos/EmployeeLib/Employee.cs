using System.ComponentModel.DataAnnotations.Schema;


namespace EmployeeLib
{
    [Table("Employee")]   //Maps the Emp class to Employee table in DB
    public class Employee
    {
        
        private int _Eid;
        
        private string _Ename;

        public Employee(int _Eid,string _Ename)
        {
            this._Eid = _Eid;
            this._Ename = _Ename;
        }
        [Column("EId", TypeName = "int")]
        public int Eid
		{
			get { return _Eid; }
			set { _Eid = value; }
		}
        [Column("EName", TypeName = "varchar(50)")]
        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }
    }
}
