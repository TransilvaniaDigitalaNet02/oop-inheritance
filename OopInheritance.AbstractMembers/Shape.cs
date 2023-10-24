using System;

namespace OopInheritance.AbstractMembers
{
    public abstract class Shape
    {
        public Shape(Point[] points)
        {
            AllPoints = points;
        }

        public Point[] AllPoints { get; }

        public abstract double CalculateArea();
    }

    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
            : base(new[] { p1, p2, p2})
        {
        }

        public override double CalculateArea()
        {
            return 0;
        }
    }

    public abstract class AbstractClass
    {
        public void Test()
        {
            Console.Write("test");
        }
    }
}