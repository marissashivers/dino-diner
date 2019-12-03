/*  Sodasaurus.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// OLD-FASHION SODA
    /// A drink that contains carbonated water, a sweetener, and a natural or artificial flavoring.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private backing variable for size
        private Size _size;

        // Private backing variable for flavor
        private SodasaurusFlavor _flavor;

        /// <summary>
        /// Gets and sets the size and adjusts calories and price according to size
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
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                } // end switch
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
            } // end set
        }

        /// <summary>
        /// Flavor of the Sodasaurus beverage.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return _flavor;
            }
            set
            {
                _flavor = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Water",
                    "Natural Flavors",
                    "Cane Sugar"
                };
                return ingredients;
            }
        }


        /// <summary>
        /// Special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<String>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            base.Price = 1.50;
            base.Calories = 112;
            this.Size = Size.Small;
        }

        /// <summary>
        /// ToString for Sodasaurus
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
            sb.Append(this.Flavor + " ");
            sb.Append("Sodasaurus");
            return sb.ToString();
        }
        /// <summary>
        /// get basic name (no size or anything)
        /// </summary>
        /// <returns></returns>
        public override string GetBasicName()
        {
            return "Sodasaurus";
        }

    }
}
