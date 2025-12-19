using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice
{
    internal class JSON:BaseReport
    {

        protected override void Parse()
        {
            Console.WriteLine("JSON Parse done....");
        }

        protected override void Validate()
        {
            Console.WriteLine("JSON validation done....");
        }

        protected override void Save()
        {
            Console.WriteLine("JSON get saved....");
        }
    }
}
