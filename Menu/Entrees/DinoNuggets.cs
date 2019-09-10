using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        private int numNuggets = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            get
            {
                List<String> Ingredients = new List<string>();
                for (int i = 0; i < numNuggets; i++)
                {
                    Ingredients.Add("Chicken Nugget");
                }
                Ingredients.Add("Wing Sauce");
                return Ingredients;
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

        public void AddNugget()
        {
            numNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}
