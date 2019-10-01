using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Hydration is important
    /// </summary>
    public class Water : Drink
    {
        private bool _lemon = false;

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
    }
}
