using Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figure.UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The sides can't have negative values.")]
        public void NegativeSidesTest1()
        {
            double a, b, c;
            a = -1;
            b = 1;
            c = 3;

            var triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The sides can't have negative values.")]
        public void NegativeSidesTest2()
        {
            double a, b, c;
            a = -1;
            b = 1;
            c = 3;

            var triangle = new Triangle(b, a, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The sides can't have negative values.")]
        public void NegativeSidesTest3()
        {
            double a, b, c;
            a = -1;
            b = 1;
            c = 3;

            var triangle = new Triangle(b, c, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The sum of any two sides must be less than the third side.")]
        public void NotExistTriangleTest1()
        {
            double a, b, c;
            a = 3;
            b = 4;
            c = 9;

            var triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The sum of any two sides must be less than the third side.")]
        public void NotExistTriangleTest2()
        {
            double a, b, c;
            a = 3;
            b = 4;
            c = 9;

            var triangle = new Triangle(b, a, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The sum of any two sides must be less than the third side.")]
        public void NotExistTriangleTest3()
        {
            double a, b, c;
            a = 3;
            b = 4;
            c = 9;

            var triangle = new Triangle(b, c, a);
        }

        [TestMethod]
        public void GetAreaTest()
        {
            double a, b, c;
            a = 5;
            b = 6;
            c = 8;

            var triangle = new Triangle(a, b, c);
            var area = triangle.GetArea();

            var halfMeter = (a + b + c) / 2;
            var result = Math.Sqrt(halfMeter * (halfMeter - a) * (halfMeter - b) * (halfMeter - c));

            Assert.AreEqual(area, result);
        }

        [TestMethod]
        public void IsRectangleTest()
        {
            double a, b, c;
            a = 3;
            b = 4;
            c = 5;

            var triangleRectangle = new Triangle(a, b, c);
            Assert.IsTrue(triangleRectangle.IsRectangle());

            a = 5;
            b = 6;
            c = 7;
            var triangleNotRectangle = new Triangle(a, b, c);
            Assert.IsFalse(triangleNotRectangle.IsRectangle());
        }
    }
}
