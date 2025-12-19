using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Virtual_New
{
    internal class Derived:Base
    {
        public override void virtualProp()
        {
            Console.WriteLine("In Derived Override Prop");
        }

        public new void normalProp()
        {
            Console.WriteLine("In derived new Normal prop");
        }
    }
}
