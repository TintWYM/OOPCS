using System;
namespace Workshop_Exception
{
	public class Triangle
	{
		private double side1, side2, side3;

		public Triangle(double side1, double side2, double side3)
		{
			if (!IsValidTriangle(side1, side2, side3))
			{
				throw new BadTriangle("Invalid sides");
			}
			else {
				this.side1 = side1;
				this.side2 = side2;
				this.side3 = side3;
			}
		}

		private static bool IsValidTriangle(double side1, double side2, double side3) {
			return side1 > 0 && side2 > 0 && side3 > 0 &&
			   side1 + side2 > side3 &&
			   side1 + side3 > side2 &&
			   side2 + side3 > side1;
        }

		public double Perimeter() {
			return side1 + side2 + side3;
		}

		public double Area() {
			double s = Perimeter() / 2;
			return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
		}
    }
}

