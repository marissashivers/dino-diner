/*  Tyrannotea.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Iced tea
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private lemon variable
        private bool _lemon = false;

        // Private sweet variable
        private bool _sweet = false;

        // Private size backing variable
        private Size _size;

        /// <summary>
        /// Bool for lemon property
        /// </summary>
        public bool Lemon
        {
            get
            {
                return _lemon;
            }
            set
            {
                _lemon = value;
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Bool for sweet property
        /// </summary>
        public bool Sweet
        {
            get
            {
                return _sweet;
            }
             set
            {
                _sweet = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets and sets the size, and adjusts price/calories based on size
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
                switch(_size)
                {
                    case (Size.Small):
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case (Size.Medium):
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case (Size.Large):
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
            } // end set
        }

        /// <summary>
        /// Special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (_lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            base.Price = 0.99;
            base.Calories = 8;
            this.Size = Size.Small;
        }

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
                    "Tea"
                };
                if (_lemon) ingredients.Add("Lemon");
                if (_sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Adds the lemon
        /// </summary>
        public void AddLemon()
        {
            this._lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes a lemon
        /// </summary>
        public void RemoveLemon()
        {
            this._lemon = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Makes the tea sweet (adds cane sugar) and doubles calories
        /// </summary>
        public void AddSweetener()
        {
            _sweet = true;
            this.Calories *= 2;
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// Removes sweetener and halves calories
        /// </summary>
        public void RemoveSweetener()
        {
            if (_sweet)
            {
                _sweet = false;
                this.Calories /= 2;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// ToString for Tyrannotea
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
            if (this.Sweet) sb.Append("Sweet ");
            sb.Append("Tyrannotea");
            return sb.ToString();
        }
    }
}
