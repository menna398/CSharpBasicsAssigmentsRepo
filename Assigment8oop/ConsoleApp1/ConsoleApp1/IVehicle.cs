using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IVehicle
    {
        public void StartEngine();
        public void StopEngine();
    }

    class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }

    class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }



}
