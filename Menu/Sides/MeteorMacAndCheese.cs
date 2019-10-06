using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Macaroni and Cheese with Sausages
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem
    {
        private Size PrivateSize;

        //MeteorMacAndCheese m = new MeteorMacAndCheese();
        //m.Size = Size.Small;

        /// <summary>
        /// Gets and sets size, and sets price/calories according to size
        /// </summary>
        public override Size Size // Size property
        {
            get
            {
                return PrivateSize;
            }
            set
            {
                PrivateSize = value;
                switch (PrivateSize)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the current list of ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Meteor Mac and Cheese
        /// </summary>
        public MeteorMacAndCheese()
        {
            base.Price = 0.99;
            base.Calories = 420;
        }
    }
}
