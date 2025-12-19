using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Abstract_Interface
{
    internal static class FactoryDesignClass
    {
        public static Report CreateReport(string type)
        {
            switch (type.ToUpper()) {
                case "PDF":
                    return new PDF();
      
                case "JSON":
                    return new PDF();

                default: throw new ArgumentException("Invalid report type");
            }
        }
    }
}
