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
        /// Size.Small
        /// </summary>
        Small,
        /// <summary>
        /// Size.Medium
        /// </summary>
        Medium,
        /// <summary>
        /// Size.Large
        /// </summary>
        Large
    }

    /// <summary>
    /// Abstract class for a drink.
    /// </summary>
    public abstract class Drink : IMenuItem
    {

        private bool _ice = true;
        /// <summary>
        /// Ice boolean
        /// </summary>
        public bool Ice
        {
            get
            {
                return _ice;
            }
            set
            {
                _ice = value;
            }
        }

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
        /// Size enum
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Holds the ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }


}
