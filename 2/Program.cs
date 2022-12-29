using System;


namespace exer2
{
    public class Rectangle
    {
        private double side1, side2;

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area { get { return side1 * side2; } }

        public double Perimeter { get { return 2 * (side2 + side1); } }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1 and side2:");
            Rectangle r1 = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Area:{r1.Area}\tPerimeter:{r1.Perimeter}");
        }
    }

}
