using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Figure
{
    /// <summary>
    /// A geometric shape formed by three segments that connect three points that do not lie on the same straight line.
    /// </summary>
    public class Triangle : IFigure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        /// <summary>
        /// Initializes a new instance of the Figure.Triangle class with the specified three sides.
        /// </summary>
        /// <param name="a">First side.</param>
        /// <param name="b">Second side.</param>
        /// <param name="c">Third side.</param>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("The sides can't have negative values.");
            if (a > b + c || b > a + c || c > a + b)
                throw new ArgumentOutOfRangeException("The sum of any two sides must be less than the third side."); 

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Calculates the area of a triangle on three sides according to the Heron formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double GetArea()
        {
            var halfMeter = (A + B + C) / 2;
            var area = Math.Sqrt(halfMeter * (halfMeter - A) * (halfMeter - B) * (halfMeter - C));
            return area;
        }

        /// <summary>
        /// Checks whether the triangle is rectangular.
        /// </summary>
        /// <returns>True if a rectangle; otherwise, false.</returns>
        public bool IsRectangle()
        {
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2) ||
                Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2) ||
                Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
                return true;
            return false;
        }
    }
}
