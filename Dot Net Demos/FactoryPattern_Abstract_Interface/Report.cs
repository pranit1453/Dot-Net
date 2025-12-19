using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Abstract_Interface
{
    internal abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void generateReport()
        {
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report generated.");
        }
    }
}
