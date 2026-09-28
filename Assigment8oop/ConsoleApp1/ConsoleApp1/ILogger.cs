using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ILogger
    {
        public void Log()
        {
            Console.WriteLine("Default logging.");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Console logging.");
        }
    }

}
