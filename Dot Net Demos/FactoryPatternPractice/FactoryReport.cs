using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice
{
    internal static class FactoryReport
    {
        public static BaseReport BaseFactoryReport(string type)
        {
            switch (type.ToUpper())
            {
                case "PDF":
                    return new PDF();
                case "JSON":
                    return new JSON();
                default: 
                    throw new ArgumentException("Invalid report type");
            }
        }
    }
}
