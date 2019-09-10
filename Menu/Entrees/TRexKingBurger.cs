using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool wholeWheatBun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onions = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            get
            {
                List<String> Ingredients = new List<String>();
                Ingredients.Add("Steakburger Pattie");
                Ingredients.Add("Steakburger Pattie");
                Ingredients.Add("Steakburger Pattie");
                if (wholeWheatBun) Ingredients.Add("Whole Wheat Bun");
                if (lettuce) Ingredients.Add("Lettuce");
                if (tomato) Ingredients.Add("Tomato");
                if (onions) Ingredients.Add("Onion");
                if (pickle) Ingredients.Add("Pickle");
                if (mustard) Ingredients.Add("Mustard");
                if (mayo) Ingredients.Add("Mayo");
                return Ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            wholeWheatBun = false;
        }

        public void HoldLettuce()
        {
            lettuce = false;
        }

        public void HoldTomato()
        {
            tomato = false;
        }

        public void HoldOnion()
        {
            onions = false;
        }

        public void HoldPickle()
        {
            pickle = false;
        }

        public void HoldKetchup()
        {
            ketchup = false;
        }

        public void HoldMustard()
        {
            mustard = false;
        }

        public void HoldMayo()
        {
            mayo = false;
        }
    }
}
