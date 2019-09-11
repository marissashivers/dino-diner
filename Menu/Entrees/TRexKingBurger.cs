using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// T-Rex King Burger (A triple 1/2 steakburger with all the fixings)
    /// </summary>
    public class TRexKingBurger
    {
        private bool wholeWheatBun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onions = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            get
            {
                List<String> Ingredients = new List<String>();
                Ingredients.Add("Steakburger Pattie");
                Ingredients.Add("Steakburger Pattie");
                Ingredients.Add("Steakburger Pattie");
                if (wholeWheatBun) Ingredients.Add("Whole Wheat Bun");
                if (lettuce) Ingredients.Add("Lettuce");
                if (tomato) Ingredients.Add("Tomato");
                if (onions) Ingredients.Add("Onion");
                if (pickle) Ingredients.Add("Pickle");
                if (ketchup) Ingredients.Add("Ketchup");
                if (mustard) Ingredients.Add("Mustard");
                if (mayo) Ingredients.Add("Mayo");
                return Ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Sets bun boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldBun()
        {
            wholeWheatBun = false;
        }

        /// <summary>
        /// Sets lettuce boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Sets tomato boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }

        /// <summary>
        /// Sets onion boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
        }

        /// <summary>
        /// Sets pickle boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }

        /// <summary>
        /// Sets ketchup boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }

        /// <summary>
        /// Sets mustard boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }

        /// <summary>
        /// Sets mayo boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }
    }
}
