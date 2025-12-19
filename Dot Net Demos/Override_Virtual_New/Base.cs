using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Virtual_New
{
    internal class Base
    {
        public virtual void virtualProp()
        {
            Console.WriteLine("Base Virtual Property...");
        }

        public void normalProp()
        {
            Console.WriteLine("Base Normal Property...");
        }
    }
}
