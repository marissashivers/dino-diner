/*  Triceritots.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tater Tots
    /// </summary>
    public class Triceritots: Side, IMenuItem
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the current list of ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potatoes");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Triceritots
        /// </summary>
        public Triceritots()
        {
            base.Price = 0.99;
            base.Calories = 352;
        }

        /// <summary>
        /// ToString for Triceritots
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Triceritots";
            }
            if (this.Size == Size.Medium)
            {
                return "Medium Triceritots";
            }
            if (this.Size == Size.Large)
            {
                return "Large Triceritots";
            }
            return base.ToString();
        }
    }
}
