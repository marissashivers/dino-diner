/*  DinoNuggets.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets (Six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private number of nuggets
        private int _numNuggets = 6;

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a property changed
        /// </summary>
        /// <param name="propertyName">String property name</param>

        protected override void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < _numNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                    
                }
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
                if (_numNuggets > 6)
                {
                    special.Add($"{_numNuggets - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Dino Nuggets
        /// </summary>
        public DinoNuggets()
        {
            base.Price = 4.25;
            for (int i = 0; i < _numNuggets; i++)
            {
                base.Calories += (uint)59;
            }
        }

        /// <summary>
        /// Adds nugget to ingredients, increases price and calories.
        /// </summary>
        public void AddNugget()
        {
            _numNuggets++;
            Price += 0.25;
            Calories += 59;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories"); // not in IOrderItem, but should still put
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        /// <summary>
        /// ToString for Dinonuggets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
