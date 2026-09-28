using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// Part 2

namespace ConsoleApp1
{
    internal interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }

        void GetNextArea();

        void ResetSeries();
    }

    class SquareSeries : IShapeSeries
    {
        private int side = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }
    }

    class CircleSeries : IShapeSeries
    {
        private int radius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }

    class Shape2 : IComparable<Shape2>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape2(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape2 other)
        {
            return Area.CompareTo(other.Area);
        }
    }

    abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public GeometricShape(double dimension1, double dimension2)
        {
            Dimension1 = dimension1;
            Dimension2 = dimension2;
        }

        public abstract double CalculateArea();

        public abstract double Perimeter { get; }
    }

    class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height)
            : base(baseLength, height)
        {
        }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                // Not enough information to calculate
                // a general triangle perimeter.
                return 0;
            }
        }
    }

    class Rectangle2 : GeometricShape
    {
        public Rectangle2(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }
    }

}
