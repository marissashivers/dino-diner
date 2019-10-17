/*  PrehistoricPBJ.cs
*   Author: Marissa Shivers
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Prehistoric PB and J (A peanut butter and jelly sandwich)
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem
    {
        // Privaite peanut butter and jelly to be used only in this class.
        private bool peanutButter = true;
        private bool jelly = true;

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
        /// same as ToString()
        /// </summary>
        public string Description
        {
            get
            {
                return "Prehistoric PB&J";
            }
        }

        /// <summary>
        /// special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("No peanut butter");
                if (!jelly) special.Add("No jelly");
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
        }

        /// <summary>
        /// Sets jelly boolean to false so it doesn't get added to the ingredients
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
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
