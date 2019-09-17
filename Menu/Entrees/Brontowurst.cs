using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst (Brautwurst with peppers and onions in a bun)
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool wholeWheatBun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Brontwurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Sets bun boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }


        /// <summary>
        /// Sets peppers boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Sets onion boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
