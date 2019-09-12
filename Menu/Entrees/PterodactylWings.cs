using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Pterodactyl Wings (Chicken wings glazed with a signature hot sauce)
    /// </summary>
    public class PterodactylWings
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<String> Ingredients
        {
            
            get
            {
                List<String> ingredients = new List<String>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

    }
}
