﻿/*  Brontowurst.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst (Brautwurst with peppers and onions in a bun)
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem
    {
        // Private variables for bun, peppers, and onions to be used only in this class.
        private bool _wholeWheatBun = true;
        private bool _peppers = true;
        private bool _onions = true;

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (_wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (_peppers) ingredients.Add("Peppers");
                if (_onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!_wholeWheatBun) special.Add("Hold Bun");
                if (!_peppers) special.Add("Hold Peppers");
                if (!_onions) special.Add("Hold Onions");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Brontwurst
        /// </summary>
        public Brontowurst()
        {
            base.Price = 5.36;
            base.Calories = 498;
        }

        /// <summary>
        /// Sets bun boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldBun()
        {
            this._wholeWheatBun = false;
        }


        /// <summary>
        /// Sets peppers boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this._peppers = false;
        }

        /// <summary>
        /// Sets onion boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldOnion()
        {
            this._onions = false;
        }

        /// <summary>
        /// ToString for Brontowurst
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
