using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice
{
    internal abstract class BaseReport:IReport
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();

        public void GenerateReport()
        {
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report get Generated...");
        }
    }
}
