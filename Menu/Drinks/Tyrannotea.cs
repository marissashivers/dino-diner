using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// 
    /// </summary>
    public class Tyrannotea : Drink
    {
        private bool lemon = false;
        private bool sweet = false;

        private Size privateSize;

        /// <summary>
        /// Gets and sets the size, and adjusts price/calories based on size
        /// </summary>
        public override Size Size
        {
            get
            {
                return privateSize;
            }
            set
            {
                privateSize = value;
                switch(privateSize)
                {
                    case (Size.Small):
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case (Size.Medium):
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case (Size.Large):
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            } // end set
        }

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (lemon) ingredients.Add("Lemon");
                if (sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Adds the lemon
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
        }

        /// <summary>
        /// Makes the tea sweet (adds cane sugar) and doubles calories
        /// </summary>
        public void AddSweetener()
        {
            sweet = true;
            this.Calories = this.Calories * 2;
        }
    }
}
