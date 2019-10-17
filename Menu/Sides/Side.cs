/*  Side.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Size enumeration variable for Size.Small, Size.Medium, and Size.Large
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// Small size
        /// </summary>
        Small,
        /// <summary>
        /// Medium size
        /// </summary>
        Medium, 
        /// <summary>
        /// Large size
        /// </summary>
        Large
    }

    /// <summary>
    /// Abstract base class for a "side".
    /// </summary>
    public abstract class Side : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
