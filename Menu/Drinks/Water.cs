using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Hydration is important
    /// </summary>
    public class Water : Drink
    {
        private bool lemon = false;

        private Size privateSize;

        /// <summary>
        /// Gets and sets size (same for all)
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
                switch (privateSize)
                {
                    case (Size.Small):
                    case (Size.Medium):
                    case (Size.Large):
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Cosntructor for water
        /// </summary>
        public Water()
        {
            base.Price = 0.10;
            base.Calories = 0;
        }

        /// <summary>
        /// Adds a lemon
        /// </summary>
        public void AddLemon()
        {
           this.lemon = true;
        }
    }
}
