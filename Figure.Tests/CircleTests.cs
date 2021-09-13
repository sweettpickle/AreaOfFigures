using Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figure.UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "The radius can't be negative.")]
        public void NegativeRadiusTest()
        {
            var radius = -1;
            var circle = new Circle(radius);
        }

        [TestMethod]
        public void GetAreaTest()
        {
            var radius = 3;
            var circle = new Circle(radius);
            var area = circle.GetArea();

            var result = Math.PI * radius * radius;

            Assert.AreEqual(area, result);
        }
    }
}
