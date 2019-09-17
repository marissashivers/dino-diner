using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Steakosaurus Burger (A 1/2 pound steakburger)
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
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
        /// Constructor for Steakosaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
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
    }
}
