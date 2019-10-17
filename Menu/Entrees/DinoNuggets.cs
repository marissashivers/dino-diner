/*  DinoNuggets.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets (Six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem
    {
        // Private number of nuggets
        private int numNuggets = 6;

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < numNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                    
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Same as ToString()
        /// </summary>
        public string Description
        {
            get
            {
                return "Dino-Nuggets";
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
                int num = numNuggets - 6;
                if (numNuggets != 0) special.Add("Add " + num + " nuggets");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Dino Nuggets
        /// </summary>
        public DinoNuggets()
        {
            base.Price = 4.25;
            for (int i = 0; i < numNuggets; i++)
            {
                base.Calories += (uint)59;
            }
        }

        /// <summary>
        /// Adds nugget to ingredients, increases price and calories.
        /// </summary>
        public void AddNugget()
        {
            numNuggets++;
            base.Price += 0.25;
            base.Calories += 59;
        }

        /// <summary>
        /// ToString for Dinonuggets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
