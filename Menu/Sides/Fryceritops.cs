using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Fryceritops class - French Fries
    /// </summary>
    public class Fryceritops : Side // inherits the side abstract class
    {
        // private backing variable
        private Size size;

        /// <summary>
        /// Gets and sets size, and sets price/calories according to size
        /// </summary>
        public override Size Size
        {          
            get
            {
                return Size;
            }
            set
            {
                size = value;
                switch(size)
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
            }
        }

        public List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<String>();

                return Ingredients;
            }
        }

        public Fryceritops()
        {
            base.Calories = 222; // don't need "base", but can include it
            base.Price = 0.99;
        }
    }
}
