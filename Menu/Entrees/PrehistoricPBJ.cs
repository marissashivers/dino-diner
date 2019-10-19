/*  PrehistoricPBJ.cs
*   Author: Marissa Shivers
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Prehistoric PB and J (A peanut butter and jelly sandwich)
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Privaite peanut butter and jelly to be used only in this class.
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a property changed
        /// </summary>
        /// <param name="propertyName">String property name</param>

        protected void NotifyOfPropertyChanged(string propertyName)
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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Prehistoric PB and J
        /// </summary>
        public PrehistoricPBJ()
        {
            base.Price = 6.52;
            base.Calories = 483;
        }

        /// <summary>
        /// Sets peanut butter boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets jelly boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// ToString for Prehistoric PBJ
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
