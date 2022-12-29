using Microsoft.VisualStudio.TestTools.UnitTesting;
using exer2;
using exer3;

namespace AllTests
{
    [TestClass]
    public class TestRectangle
    {
        private double a, b;
        private Rectangle? r;

        [TestInitialize]
        public void SetUp()
        {
            a = 33.12;
            b = 12.12;
            r = new Rectangle(a, b);
        }

        [TestMethod]
        public void TestArea()
        {
            if (r == null)
                throw new Exception();

            Assert.AreEqual(r.Area, a * b);
            Assert.AreEqual(r.AreaCalculator(), a * b);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            if (r == null)
                throw new Exception();

            Assert.AreEqual(r.Perimeter, 2 * (a + b));
            Assert.AreEqual(r.PerimeterCalculator(), 2 * (a + b));
        }

    }

    [TestClass]
    public class TestFigure
    {
        private Figure? f;
        private Point[]? arr;

        [TestInitialize]
        public void SetUp()
        {
            arr = new Point[5];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new Point(i, i + 3);

            f = new Figure(arr);
        }

        [TestMethod]
        public void TestLength()
        {
            if (arr == null)
                throw new Exception();

            double length = Math.Sqrt(Math.Pow(arr[1].X - arr[2].X, 2) + Math.Pow(arr[1].Y - arr[2].Y, 2));

            Assert.AreEqual(f.LengthSize(arr[1], arr[2]), length);
            Assert.AreEqual(f.LengthSize(arr[1], arr[4]), -1);
        }

        [TestMethod]

        public void TestFPerimeter()
        {
            if (arr == null)
                throw new Exception();

            double sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                sum += Math.Sqrt(Math.Pow(arr[i].X - arr[i + 1].X, 2) + Math.Pow(arr[i].Y - arr[i + 1].Y, 2));

            Assert.AreEqual(f.PerimeterCalculator(), sum);
        }
    }
}