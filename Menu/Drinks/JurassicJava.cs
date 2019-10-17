﻿/*  JurassicJava.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// JurrassicJava = Coffee
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem
    {
        // Private room for cream variable
        private bool _roomForCream = false;

        // Private decaf variable
        private bool _decaf = false;

        // Private backing variable
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
        /// Description: Matches ToString() implementation
        /// </summary>
        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                if (this.Size == Size.Small)
                {
                    sb.Append("Small ");
                }
                if (this.Size == Size.Medium)
                {
                    sb.Append("Medium ");
                }
                if (this.Size == Size.Large)
                {

                    sb.Append("Large ");
                }
                if (this.Decaf) sb.Append("Decaf ");
                sb.Append("Jurassic Java");
                return sb.ToString();
            }
        }

        /// <summary>
        /// Special instructions for making Jurassic Java
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (_roomForCream) special.Add("Leave room for cream");
                if (_decaf) special.Add("Decaf");
                if (Ice) special.Add("Add ice");
                return special.ToArray();
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

        /// <summary>
        /// ToString for Jurassic Java
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Size == Size.Small)
            {
                sb.Append("Small ");
            }
            if (this.Size == Size.Medium)
            {
                sb.Append("Medium ");
            }
            if (this.Size == Size.Large)
            {

                sb.Append("Large ");
            }
            if (this.Decaf) sb.Append("Decaf ");
            sb.Append("Jurassic Java");
            return sb.ToString();
        }
    }
}
