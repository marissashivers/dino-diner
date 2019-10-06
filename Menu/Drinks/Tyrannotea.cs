using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Iced tea
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        // Private lemon variable
        private bool _lemon = false;

        // Private sweet variable
        private bool _sweet = false;

        // Private size backing variable
        private Size _size;

        /// <summary>
        /// Bool for lemon property
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
        /// Bool for sweet property
        /// </summary>
        public bool Sweet
        {
            get
            {
                return _sweet;
            }
             set
            {
                _sweet = value;
            }
        }

        /// <summary>
        /// Gets and sets the size, and adjusts price/calories based on size
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
                switch(_size)
                {
                    case (Size.Small):
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case (Size.Medium):
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case (Size.Large):
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            } // end set
        }

        /// <summary>
        /// Constructor for Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            base.Price = 0.99;
            base.Calories = 8;
            this.Size = Size.Small;
        }

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (_lemon) ingredients.Add("Lemon");
                if (_sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Adds the lemon
        /// </summary>
        public void AddLemon()
        {
            _lemon = true;
        }

        /// <summary>
        /// Makes the tea sweet (adds cane sugar) and doubles calories
        /// </summary>
        public void AddSweetener()
        {
            _sweet = true;
            this.Calories = this.Calories * 2;
        }

        /// <summary>
        /// Removes sweetener and halves calories
        /// </summary>
        public void RemoveSweetener()
        {
            if (_sweet)
            {
                _sweet = false;
                this.Calories = this.Calories / 2;
            }
        }

        /// <summary>
        /// ToString for Tyrannotea
        /// </summary>
        /// <returns>Sttring with size</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Size == Size.Small)
            {
                sb.Append("Small ");
            }
            if (this.Size == Size.Medium)
            {
                sb.Append("Medium ");
            }
            if (this.Size == Size.Large)
            {
                sb.Append("Large ");
            }
            if (this.Sweet) sb.Append("Sweet ");
            sb.Append("Tyrannotea");
            return sb.ToString();
        }
    }
}
