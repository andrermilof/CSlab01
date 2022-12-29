using System;


namespace exer3
{
    public class Point
    {
        private int x, y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public int X { get { return x; } }

        public int Y { get { return y; } }
    }

    public class Figure
    {
        private Point[] arr;
        public string Name { get; }

        public Figure(params Point[] args)
        {
            switch (args.Length)
            {
                case 3:
                    Name = "triangle";
                    break;
                case 4:
                    Name = "quadrangle";
                    break;
                case 5:
                    Name = "pentagon";
                    break;
                default:
                    throw new ArgumentException("Invalid arguments");
            }

            arr = new Point[args.Length];
            for (int i = 0; i < args.Length; i++)
                arr[i] = args[i];
        }

        public double LengthSize(Point A, Point B)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                if ((arr[i] == A && arr[i + 1] == B) || (arr[i] == B && arr[i + 1] == A))
                    return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            return -1;
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                sum += LengthSize(arr[i], arr[i + 1]);

            return sum;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Point[] arr = new Point[5];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new Point(i, i + 3);

            Figure f1 = new Figure(arr[0], arr[1], arr[2]);
            Figure f2 = new Figure(arr[0], arr[1], arr[2], arr[3]);
            Figure f3 = new Figure(arr);

            Console.WriteLine($"{f1.Name}\t{f1.PerimeterCalculator()}");
            Console.WriteLine($"{f2.Name}\t{f2.PerimeterCalculator()}");
            Console.WriteLine($"{f3.Name}\t{f3.PerimeterCalculator()}");
        }
    }
}
