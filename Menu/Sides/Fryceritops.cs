﻿/*  Fryceritops.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fryceritops class - French Fries
    /// </summary>
    public class Fryceritops : Side, IMenuItem, IOrderItem
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
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// same as ToString()
        /// </summary>
        public string Description
        {
            get
            {
                if (this.Size == Size.Small)
                {
                    return "Small Friceritops";
                }
                if (this.Size == Size.Medium)
                {
                    return "Medium Friceritops";
                }
                if (this.Size == Size.Large)
                {
                    return "Large Friceritops";
                }
                return base.ToString();
            }
        }

        /// <summary>
        /// special preparation instructions
        /// </summary>
        public string[] Special
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
                return "Small Friceritops";
            }
            if (this.Size == Size.Medium)
            {
                return "Medium Friceritops";
            }
            if (this.Size == Size.Large)
            {
                return "Large Friceritops";
            }
            return base.ToString();
        }
    }
}
