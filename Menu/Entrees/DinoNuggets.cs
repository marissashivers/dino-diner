using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// DinoNuggets (Six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets
    {
        private int numNuggets = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }


        public List<String> Ingredients
        {
            get
            {
                List<String> ingredients = new List<String>();
                for (int i = 0; i < numNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                    
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            for (int i = 0; i < numNuggets; i++)
            {
                this.Calories += (uint)59;
            }
        }

        /// <summary>
        /// Adds nugget to ingredients, increases price and calories.
        /// </summary>
        public void AddNugget()
        {
            numNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}
