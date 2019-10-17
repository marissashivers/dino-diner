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
        private bool wholeWheatBun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// same as ToString
        /// </summary>
        public string Description
        {
            get
            {
                return "Steakosaurus Burger";
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
                if (!wholeWheatBun) special.Add("No bun");
                if (!pickle) special.Add("No pickle");
                if (!ketchup) special.Add("No ketchup");
                if (!mustard) special.Add("No mustard");
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
            this.wholeWheatBun = false;
        }

        /// <summary>
        /// Sets puckle boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Sets ketchup boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Sets mustard boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
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
