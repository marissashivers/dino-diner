using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Veloci-Wrap (A chicken ceasar wrap)
    /// </summary>
    public class VelociWrap
    {
        private bool ceasarDressing = true;
        private bool romaineLettuce = true;
        private bool parmesanCheese = true;

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public List<string> Ingredients
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
        /// Constructor for VelociWrap that sets price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
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
    }
}
