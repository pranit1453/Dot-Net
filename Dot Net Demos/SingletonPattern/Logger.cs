using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice
{
    internal class Logger
    {
        private static readonly Logger _Logger = new Logger();
        static int count=0;
        private Logger()
        {
            count++;
            Console.WriteLine($"Logger object is created for first{count}");
        }

        public static Logger GetMyLogger()
        {
            return _Logger;
        }

        public void Log(string message)
        {
            Console.WriteLine("---Logged created at {0} ,message is {1}...",DateTime.Now.ToString(),message);
        }
    }
}
