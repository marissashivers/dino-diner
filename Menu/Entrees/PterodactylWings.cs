using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Pterodactyl Wings (Chicken wings glazed with a signature hot sauce)
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Gets current list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Pterodactyl Wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

    }
}
