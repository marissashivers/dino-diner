using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// JurrassicJava = Coffee
    /// </summary>
    public class JurassicJava : Drink, IMenuItem
    {
        private bool _roomForCream = false;
        private bool _decaf = false;

        private Size _size;

        /// <summary>
        /// Room for cream bool property
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return _roomForCream;
            }
            set
            {
                _roomForCream = value;
            }
        }

        /// <summary>
        /// Decaf bool property
        /// </summary>
        public bool Decaf
        {
            get
            {
                return _decaf;
            }
            set
            {
                _decaf = value;
            }
        }

        /// <summary>
        /// Size property
        /// </summary>
        public override Size Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                switch (_size)
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
        public JurassicJava()
        {
            this.Ice = false;
            base.Price = 0.59;
            base.Calories = 2;
            this.Size = Size.Small;
            this.RoomForCream = false;
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
            base.Ice = true;
        }
    }
}
