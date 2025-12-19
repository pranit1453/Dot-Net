using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Abstract_Interface
{
    internal class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parse done...");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validation done...");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF get Saved...");
        }
    }
}
