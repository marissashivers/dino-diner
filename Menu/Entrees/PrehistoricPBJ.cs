using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Prehistoric PB and J (A peanut butter and jelly sandwich)
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
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
    }
}
