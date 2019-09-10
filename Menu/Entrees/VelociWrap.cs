using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool ceasarDressing = true;
        private bool romaineLettuce = true;
        private bool parmesanCheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            get
            {
                List<String> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (ceasarDressing) ingredients.Add("Ceasar Dressing");
                if (romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (parmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldLettuce()
        {
            this.romaineLettuce = false;
        }

        public void HoldDressing()
        {
            this.ceasarDressing = false;
        }

        public void HoldCheese()
        {
            this.parmesanCheese = false;
        }
    }
}
