/*  Drink.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Size enumeration variable for Size.Small, Size.Medium, and Size.Large
    /// </summary>
    //public enum Size
   // {
        /// <summary>
        /// Size.Small
        /// </summary>
       // Small,
        /// <summary>
        /// Size.Medium
        /// </summary>
      //  Medium,
        /// <summary>
        /// Size.Large
        /// </summary>
     //   Large
    //}

    /// <summary>
    /// Abstract class for a drink.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private backing variable
        private bool _ice = true;

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a property changed
        /// </summary>
        /// <param name="propertyName">String property name</param>

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
        /// Getter for description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Abstract method for Special with getter
        /// </summary>
        public abstract string[] Special { get; }

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
            NotifyOfPropertyChanged("Special");
        }
    }


}
