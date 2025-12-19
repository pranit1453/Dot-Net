using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SQLServer:Database
    {
        public void insert()
        {
            Console.WriteLine("Record insert into SQL Server done");
        }

        public void update() 
        {
            Console.WriteLine("Record update into SQL Server done");
        }
    }
}
