/*  JurassicJava.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// JurrassicJava = Coffee
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                NotifyOfPropertyChanged("Special");
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
                NotifyOfPropertyChanged("Description");
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        } // end Size

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Water",
                    "Coffee"
                };
                return ingredients;
            }
        }


        /// <summary>
        /// Special instructions for making Jurassic Java
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (_roomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
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
            this._roomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// remove cream
        /// </summary>
        public void RemoveCream()
        {
            this._roomForCream = false;
            NotifyOfPropertyChanged("Special");
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
