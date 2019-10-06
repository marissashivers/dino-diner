using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Veloci-Wrap (A chicken ceasar wrap)
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
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
