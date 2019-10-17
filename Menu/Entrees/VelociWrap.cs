﻿/*  VelociWrap.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Veloci-Wrap (A chicken ceasar wrap)
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem
    {
        // Private boolean ingredients to be used only in this class
        private bool ceasarDressing = true;
        private bool romaineLettuce = true;
        private bool parmesanCheese = true;

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (ceasarDressing) ingredients.Add("Ceasar Dressing");
                if (romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (parmesanCheese) ingredients.Add("Parmesan Cheese");
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
                return "Veloci-Wrap";
            }
        }
        
        /// <summary>
        /// Special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!ceasarDressing) special.Add("No dressing");
                if (!romaineLettuce) special.Add("No lettuce");
                if (!parmesanCheese) special.Add("No parmesan cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for VelociWrap that sets price and calories
        /// </summary>
        public VelociWrap()
        {
            base.Price = 6.86;
            base.Calories = 356;
        }

        /// <summary>
        /// Sets lettuce boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.romaineLettuce = false;
        }

        /// <summary>
        /// Sets dressing boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldDressing()
        {
            this.ceasarDressing = false;
        }

        /// <summary>
        /// Sets cheese boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldCheese()
        {
            this.parmesanCheese = false;
        }

        /// <summary>
        /// ToString for Velociwrap
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
