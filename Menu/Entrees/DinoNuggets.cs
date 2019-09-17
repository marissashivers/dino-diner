using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// DinoNuggets (Six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets : Entree
    {
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
    }
}
