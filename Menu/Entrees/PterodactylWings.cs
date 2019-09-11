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
                Ingredients.Add("Chicken");
                Ingredients.Add("Wing Sauce");
                return Ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

    }
}
