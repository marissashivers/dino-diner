/*  TRexKingBurger.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// T-Rex King Burger (A triple 1/2 steakburger with all the fixings)
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem, IOrderItem
    {
        // Private ingredient booleans to be used only in this class
        private bool _wholeWheatBun = true;
        private bool _lettuce = true;
        private bool _tomato = true;
        private bool _onions = true;
        private bool _pickle = true;
        private bool _ketchup = true;
        private bool _mustard = true;
        private bool _mayo = true;

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (_wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (_lettuce) ingredients.Add("Lettuce");
                if (_tomato) ingredients.Add("Tomato");
                if (_onions) ingredients.Add("Onion");
                if (_pickle) ingredients.Add("Pickle");
                if (_ketchup) ingredients.Add("Ketchup");
                if (_mustard) ingredients.Add("Mustard");
                if (_mayo) ingredients.Add("Mayo");
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
                if (!_lettuce) special.Add("Hold Lettuce");
                if (!_tomato) special.Add("Hold Tomato");
                if (!_onions) special.Add("Hold Onions");
                if (!_pickle) special.Add("Hold Pickle");
                if (!_ketchup) special.Add("Hold Ketchup");
                if (!_mustard) special.Add("Hold Mustard");
                if (!_mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for TRex King Burger
        /// </summary>
        public TRexKingBurger()
        {
            base.Price = 8.45;
            base.Calories = 728;
        }

        /// <summary>
        /// Sets bun boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldBun()
        {
            _wholeWheatBun = false;
        }

        /// <summary>
        /// Sets lettuce boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldLettuce()
        {
            _lettuce = false;
        }

        /// <summary>
        /// Sets tomato boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldTomato()
        {
            _tomato = false;
        }

        /// <summary>
        /// Sets onion boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldOnion()
        {
            _onions = false;
        }

        /// <summary>
        /// Sets pickle boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPickle()
        {
            _pickle = false;
        }

        /// <summary>
        /// Sets ketchup boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldKetchup()
        {
            _ketchup = false;
        }

        /// <summary>
        /// Sets mustard boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldMustard()
        {
            _mustard = false;
        }

        /// <summary>
        /// Sets mayo boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldMayo()
        {
            _mayo = false;
        }

        /// <summary>
        /// ToString for T-Rex King Burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
