using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice
{
    internal class PDF:BaseReport
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parse done....");
        }

        protected override void Validate()
        {
            Console.WriteLine("PDF validation done....");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF get saved....");
        }
    }
}
