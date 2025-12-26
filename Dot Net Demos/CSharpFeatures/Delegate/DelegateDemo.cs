using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.Delegate
{
    public delegate T MyDelegate<T>(T data1, T data2);
    public delegate bool MyDelegateBool<T>(T data1, T data2);
    public class DelegateDemo
    {
        public static T CheckMyDelegate<T>(T data1,T data2,MyDelegate<T> del)
        {
            return del(data1,data2);
        }

        public static bool CheckMyDelegateBool<T>(T data1, T data2, MyDelegateBool<T> delbool)
        {
            return delbool(data1,data2);
        }
    }
}
