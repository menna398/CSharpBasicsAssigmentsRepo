using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0;
        }

        public Car(int id)
        {
            Id = id;
            Brand = "Unknown";
            Price = 0;
        }

        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 0;
        }

        public Car(int id, string brand, double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Price: {Price}";
        }
    }

    
}
