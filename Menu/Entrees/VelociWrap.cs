/*  VelociWrap.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Veloci-Wrap (A chicken ceasar wrap)
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Private boolean ingredients to be used only in this class
        private bool _ceasarDressing = true;
        private bool _romaineLettuce = true;
        private bool _parmesanCheese = true;

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
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Flour Tortilla",
                    "Chicken Breast"
                };
                if (_ceasarDressing) ingredients.Add("Ceasar Dressing");
                if (_romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (_parmesanCheese) ingredients.Add("Parmesan Cheese");
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
                List<string> special = new List<string>();
                if (!_ceasarDressing) special.Add("Hold Dressing");
                if (!_romaineLettuce) special.Add("Hold Lettuce");
                if (!_parmesanCheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for VelociWrap that sets price and calories
        /// </summary>
        public VelociWrap()
        {
            base.Price = 6.86;
            base.Calories = 356;
        }

        /// <summary>
        /// Sets lettuce boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this._romaineLettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets dressing boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldDressing()
        {
            this._ceasarDressing = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets cheese boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldCheese()
        {
            this._parmesanCheese = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString for Velociwrap
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
