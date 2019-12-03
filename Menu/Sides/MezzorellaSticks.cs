/*  MezzorellaSticks.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fried Breaded Mozzarella Sticks
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                switch (_size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
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
                    "Cheese Product",
                    "Breading",
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
        /// Constructor for Mezzorella Sticks
        /// </summary>
        public MezzorellaSticks()
        {
            base.Calories = 540;
            base.Price = 0.99;
        }

        /// <summary>
        /// ToString for Mezzorella Sticks
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Mezzorella Sticks";
            }
            if (this.Size == Size.Medium)
            {
                return "Medium Mezzorella Sticks";
            }
            if (this.Size == Size.Large)
            {
                return "Large Mezzorella Sticks";
            }
            return base.ToString();
        }
        /// <summary>
        /// get basic name (no size or anything)
        /// </summary>
        /// <returns></returns>
        public override string GetBasicName()
        {
            return "Mezzorella Sticks";
        }
    }
}
