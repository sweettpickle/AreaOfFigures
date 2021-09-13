using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    /// <summary>
    /// The part of the plane that lies inside the circle. In other words, 
    /// it is a geometric place of points in the plane, the distance from which to a given point, 
    /// called the center of the circle, does not exceed a given non-negative radius.
    /// </summary>
    public class Circle : IFigure
    {
        private double Radius { get; set; }

        /// <summary>
        /// Initializes a new instance of the Figure.Circle class with the specified radius.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("The radius can't be negative.");

            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of a circle by radius.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
