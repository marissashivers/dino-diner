using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Tater Tots
    /// </summary>
    public class Triceritots: Side
    {
        // private backing variable
        private Size PrivateSize;

        /// <summary>
        /// Gets and sets size, and sets price/calories according to size
        /// </summary>
        public override Size Size
        {
            get
            {
                return PrivateSize;
            }
            set
            {
                PrivateSize = value;
                switch (PrivateSize)
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
    }
}
