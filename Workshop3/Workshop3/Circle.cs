using System;
namespace Workshop3
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public string Type()
        {
            return "Circle";
        }
    }
}

