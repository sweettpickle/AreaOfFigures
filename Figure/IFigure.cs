using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    /// <summary>
    /// Represents a shape from which you can get an area.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculates the area of the figure and returns the result.
        /// </summary>
        /// <returns>The area of the figure.</returns>
        public double GetArea();
    }
}
