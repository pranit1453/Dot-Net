using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Abstract_Interface
{
    internal class JSON : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("JSON Parse done...");
        }
        protected override void Validate()
        {
            Console.WriteLine("JSON Validation done...");
        }
        protected override void Save()
        {
            Console.WriteLine("JSON get Saved...");
        }

    }
}
