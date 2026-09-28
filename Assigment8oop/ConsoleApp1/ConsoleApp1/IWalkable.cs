using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IWalkable
    {
        void Walk();
    }

    class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot's normal Walk method.");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Robot's IWalkable Walk method.");
        }
    }

}
