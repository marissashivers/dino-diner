/*  CretaceousCombo.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem
    {


        // Private backing variable
        private Size _size;
        private Entree _entree = new Brontowurst();
        private Side _side = new Fryceritops();
        private Drink _drink = new Sodasaurus();

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
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return _entree;
            }
            set
            {
                _entree = value;
                _entree.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets and sets the size
        /// </summary>
        //public Side Side { get; set; } = new Fryceritops();
        public Side Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
                _side.Size = this.Size;
                _side.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return _drink;
            }
            set
            {
                _drink = value;
                _drink.Size = this.Size;
                _drink.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                /*
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
                */
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
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
                return this.Entree.ToString() + " Combo";
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
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            NotifyOfPropertyChanged("Entree");
        }

        /// <summary>
        /// ToString for 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Entree.ToString() + " Combo";
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
        }
    }
}
