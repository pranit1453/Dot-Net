using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class DataBaseFactory
    {
        public Database GetSomeDatabase(int choice)
        {
            Database db = null;
            switch (choice)
            {
                case 1:
                    db = new MySQLServer();
                    break;
                 case 2:
                    db= new SQLServer();
                    break;
                default:
                    break;
            }
            return db;
        }
    }
}
