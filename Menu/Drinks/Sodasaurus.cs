﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// OLD-FASHION SODA
    /// A drink that contains carbonated water, a sweetener, and a natural or artificial flavoring.
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size privateSize;
        private SodasaurusFlavor privateFlavor;

        /// <summary>
        /// Gets and sets the size and adjusts calories and price according to size
        /// </summary>
        public override Size Size
        {
            get
            {
                return privateSize;
            }
            set
            {
                privateSize = value;
                switch(privateSize)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                } // end switch
            } // end set
        }

        /// <summary>
        /// Flavor of the Sodasaurus beverage.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return privateFlavor;
            }
            set
            {
                privateFlavor = value;
            }
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            base.Price = 1.50;
            base.Calories = 112;
            this.Size = Size.Small;
        }
    }
}
