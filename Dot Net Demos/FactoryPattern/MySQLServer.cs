using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class MySQLServer:Database
    {
        public void insert()
        {
            Console.WriteLine("Record inserted into MySQL Server done...");
        }
        public void update()
        {
            Console.WriteLine("Record updated into MySQL Server done");
        }
    }
}
