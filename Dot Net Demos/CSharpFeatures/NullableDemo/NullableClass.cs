using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.NullableDemo
{
    public class NullableClass
    {
        //int deptID = null ------ error
        // int? deptId = null ------ no error
        /*
            Database columns
            API responses
            Optional fields
         */

        private int? deptId;
        private string? name;

        public NullableClass() {
            this.deptId = null;
            this.name = null;
        }

        public NullableClass(int deptId,string name)
        {
            this.deptId= deptId;
            this.name = name;
        }

        public int ID()
        {
            if (deptId.HasValue)
            {
                return deptId.Value;
            }
            else
            {
                return -1;
            }
            
        }

        public string Name()
        {
            // ?? returns the LEFT value if it is NOT null, otherwise it returns the RIGHT value.
            return name ?? "Name not available"; // ?? → Null-coalescing operator
        }
    }
}
