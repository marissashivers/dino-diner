/*  SteakosaurusBurger.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Steakosaurus Burger (A 1/2 pound steakburger)
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem
    {
        // Private ingredient booleans to be used only in this class
        private bool _wholeWheatBun = true;
        private bool _pickle = true;
        private bool _ketchup = true;
        private bool _mustard = true;

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                if (_wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (_pickle) ingredients.Add("Pickle");
                if (_ketchup) ingredients.Add("Ketchup");
                if (_mustard) ingredients.Add("Mustard");
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
                if (!_wholeWheatBun) special.Add("Hold Bun");
                if (!_pickle) special.Add("Hold Pickle");
                if (!_ketchup) special.Add("Hold Ketchup");
                if (!_mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Steakosaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            base.Price = 5.15;
            base.Calories = 621;
        }

        /// <summary>
        /// Sets bun boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldBun()
        {
            this._wholeWheatBun = false;
        }

        /// <summary>
        /// Sets puckle boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPickle()
        {
            this._pickle = false;
        }

        /// <summary>
        /// Sets ketchup boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this._ketchup = false;
        }

        /// <summary>
        /// Sets mustard boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldMustard()
        {
            this._mustard = false;
        }

        /// <summary>
        /// ToString for Steakosaurus Burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
