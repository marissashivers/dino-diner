using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool brautwurst = true;
        private bool wholeWheatBun = true;
        private bool peppers = true;
        private bool onions = true;
        
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<String>() { "Brautwurst" };
                if (wholeWheatBun) Ingredients.Add("Whole-wheat Bun");
                if (peppers) Ingredients.Add("Peppers");
                if (onions) Ingredients.Add("Onions");
                return Ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
