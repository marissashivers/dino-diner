/*  Fryceritops.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fryceritops class - French Fries
    /// </summary>
    public class Fryceritops : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // private backing variable
        private Size _size;

        /// <summary>
        /// Gets and sets size, and sets price/calories according to size
        /// </summary>
        public override Size Size
        {          
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                switch(_size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
            }
        }

        /// <summary>
        /// Gets the current list of ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Potato",
                    "Salt",
                    "Vegetable Oil"
                };
                return ingredients;
            }
        }

        /// <summary>
        /// special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Fryceritops
        /// </summary>
        public Fryceritops()
        {
            base.Calories = 222; // don't need "base", but can include it
            base.Price = 0.99;
        }

        /// <summary>
        /// ToString for Fryceritops
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Fryceritops";
            }
            if (this.Size == Size.Medium)
            {
                return "Medium Fryceritops";
            }
            if (this.Size == Size.Large)
            {
                return "Large Fryceritops";
            }
            return base.ToString();
        }

        public override string GetBasicName()
        {
            return "Fryceritops";
        }
    }
}
