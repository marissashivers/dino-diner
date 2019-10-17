/*  Water.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Hydration is important
    /// </summary>
    public class Water : Drink, IMenuItem, IOrderItem
    {
        // Private lemon variable
        private bool _lemon = false;

        // Private backing variable for size
        private Size _size;

        /// <summary>
        /// Lemon bool for lemon property
        /// </summary>
        public bool Lemon
        {
            get
            {
                return _lemon;
            }
            set
            {
                _lemon = value;
            }
        }

        /// <summary>
        /// Gets and sets size (same for all)
        /// </summary>
        public override Size Size
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
                    case (Size.Small):
                    case (Size.Medium):
                    case (Size.Large):
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (_lemon) ingredients.Add("Lemon");
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
                if (this.Size == Size.Small)
                {
                    return "Small Water";
                }
                if (this.Size == Size.Medium)
                {
                    return "Medium Water";
                }
                if (this.Size == Size.Large)
                {
                    return "Large Water";
                }
                return base.ToString();
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
                if (_lemon) special.Add("Add lemon");
                if (!Ice) special.Add("No ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Cosntructor for water
        /// </summary>
        public Water()
        {
            base.Price = 0.10;
            base.Calories = 0;
        }

        /// <summary>
        /// Adds a lemon
        /// </summary>
        public void AddLemon()
        {
           this._lemon = true;
        }

        /// <summary>
        /// ToString for water
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Water";
            }
            if (this.Size == Size.Medium)
            {
                return "Medium Water";
            }
            if (this.Size == Size.Large)
            {
                return "Large Water";
            }
            return base.ToString();
        }
    }
}
