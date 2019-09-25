using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// JurrassicJava = Coffee
    /// </summary>
    public class JurrasicJava : Drink
    {
        private bool RoomForCream = false;
        private bool Decaf = false;

        private Size privateSize;

        /// <summary>
        /// Size property
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case (Size.Medium):
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case (Size.Large):
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        } // end Size

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for JurrassicJava
        /// </summary>
        public JurrasicJava()
        {
            ice = false;
            base.Price = 0.59;
            base.Calories = 2;
        }

        /// <summary>
        /// Leaves room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Adds ice.
        /// </summary>
        public void AddIce()
        {
            ice = true;
        }
    }
}
