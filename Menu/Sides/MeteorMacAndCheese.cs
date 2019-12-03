/*  MeteorMacAndCheese.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Macaroni and Cheese with Sausages
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private backing variable
        private Size _size;

        //MeteorMacAndCheese m = new MeteorMacAndCheese();
        //m.Size = Size.Small;

        /// <summary>
        /// Gets and sets size, and sets price/calories according to size
        /// </summary>
        public override Size Size // Size property
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
            }
        }

        /// <summary>
        /// Gets the current list of ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Macaroni Noodles",
                    "Cheese Product",
                    "Pork Sausage"
                };
                return ingredients;
            }
        }

        /// <summary>
        /// special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
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

        /// <summary>
        /// ToString for Meteor Mac and Cheese
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Meteor Mac and Cheese";
            }
            if (this.Size == Size.Medium)
            {
                return "Medium Meteor Mac and Cheese";
            }
            if (this.Size == Size.Large)
            {
                return "Large Meteor Mac and Cheese";
            }
            return base.ToString();
        }

        public override string GetBasicName()
        {
            return "Meteor Mac and Cheese";
        }
    }
}
