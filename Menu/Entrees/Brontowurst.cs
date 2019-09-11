using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst (Brautwurst with peppers and onions in a bun)
    /// </summary>
    public class Brontowurst
    {
        private bool brautwurst = true;
        private bool wholeWheatBun = true;
        private bool peppers = true;
        private bool onions = true;
        
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<String>() { "Brautwurst" };
                if (wholeWheatBun) Ingredients.Add("Whole Wheat Bun");
                if (peppers) Ingredients.Add("Peppers");
                if (onions) Ingredients.Add("Onion");
                return Ingredients;
            }
        }

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
