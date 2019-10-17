/*  PterodactylWings.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Pterodactyl Wings (Chicken wings glazed with a signature hot sauce)
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem, IOrderItem
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
        /// same as ToString();
        /// </summary>
        public string Description
        {
            get
            {
                return "Pterodactyl Wings";
            }
        }

        /// <summary>
        /// Special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for Pterodactyl Wings
        /// </summary>
        public PterodactylWings()
        {
            base.Price = 7.21;
            base.Calories = 318;
        }

        /// <summary>
        /// ToString for Pterodactyl Wings
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

    }
}
