/*  Menu.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents the menu =)
    /// </summary>
    public class Menu
    {
        private List<IMenuItem> _menuItems;
        private List<IMenuItem> _combos;
        private List<IMenuItem> _entrees;
        private List<IMenuItem> _drinks;
        private List<IMenuItem> _sides;

        /// <summary>
        /// Property for Available Menu Items. Returns a list containing one instance
        /// of every menu item currently offered by DinoDiner
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                if (_menuItems == null)
                {
                    _menuItems = new List<IMenuItem>();

                    // Combos
                    _menuItems.Add(new CretaceousCombo(new Brontowurst()));
                    _menuItems.Add(new CretaceousCombo(new DinoNuggets()));
                    _menuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    _menuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    _menuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                    _menuItems.Add(new CretaceousCombo(new VelociWrap()));

                    //Drinks
                    _menuItems.Add(new JurassicJava());
                    _menuItems.Add(new Sodasaurus());
                    _menuItems.Add(new Tyrannotea());
                    _menuItems.Add(new Water());

                    // Entrees
                    _menuItems.Add(new Brontowurst());
                    _menuItems.Add(new DinoNuggets());
                    _menuItems.Add(new PrehistoricPBJ());
                    _menuItems.Add(new SteakosaurusBurger());
                    _menuItems.Add(new TRexKingBurger());
                    _menuItems.Add(new VelociWrap());

                    // Sides
                    _menuItems.Add(new Fryceritops());
                    _menuItems.Add(new MeteorMacAndCheese());
                    _menuItems.Add(new MezzorellaSticks());
                    _menuItems.Add(new Triceritots());
                }


                return _menuItems;
            }
            set
            {
                _menuItems = value;
            }
        }

        /// <summary>
        /// List of all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                if (_entrees == null)
                {
                    _entrees = new List<IMenuItem>();
                    // Entrees
                    _entrees.Add(new Brontowurst());
                    _entrees.Add(new DinoNuggets());
                    _entrees.Add(new PrehistoricPBJ());
                    _entrees.Add(new SteakosaurusBurger());
                    _entrees.Add(new TRexKingBurger());
                    _entrees.Add(new VelociWrap());
                }

                return _entrees;
            }
            set
            {
                _entrees = value;
            }
        }
        
        /// <summary>
        /// List of all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                if (_sides == null)
                {
                    _sides = new List<IMenuItem>();
                    // Sides
                    _sides.Add(new Fryceritops());
                    _sides.Add(new MeteorMacAndCheese());
                    _sides.Add(new MezzorellaSticks());
                    _sides.Add(new Triceritots());
                }


                return _sides;
            }
            set
            {
                _sides = value;
            }
        }
        
        /// <summary>
        /// List of all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                if (_drinks == null)
                {
                    _drinks = new List<IMenuItem>();
                    //Drinks
                    _drinks.Add(new JurassicJava());
                    _drinks.Add(new Sodasaurus());
                    _drinks.Add(new Tyrannotea());
                    _drinks.Add(new Water());
                }


                return _drinks;
            }
            set
            {
                _drinks = value;
            }
        }

        /// <summary>
        /// List of all available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                if (_combos == null)
                {
                    _combos = new List<IMenuItem>();
                    //TRexKingBurger burger = new TRexKingBurger();
                    //CretaceousCombo combo = new CretaceousCombo(burger);
                    _combos.Add(new CretaceousCombo(new Brontowurst()));
                    _combos.Add(new CretaceousCombo(new DinoNuggets()));
                    _combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    _combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    _combos.Add(new CretaceousCombo(new TRexKingBurger()));
                    _combos.Add(new CretaceousCombo(new VelociWrap()));
                }
                //combos.Add(combo);
                return _combos;
            }
            set
            {
                _combos = value;
            }
        }

        /// <summary>
        /// A HashSet representing all available ingredients (hashet so no duplicates)
        /// </summary>
        public HashSet<String> AvailableIngredients
        {
            get
            {
                HashSet<string> availableIngredients = new HashSet<string>();
                foreach(IMenuItem menuItem in AvailableMenuItems)
                {
                    foreach(string ingredient in menuItem.Ingredients)
                    {
                        availableIngredients.Add(ingredient);
                    }
                }
                return availableIngredients;
            }
        }

        /// <summary>
        /// Displays full menu comtents separated by \n
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // return full list of menu items
            return base.ToString();
        }

        /// <summary>
        /// Search by a user specified query
        /// </summary>
        /// <param name="items"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> items, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem currentItem in items)
            {
                string currentItemString = currentItem.ToString().ToLower();
                if (currentItemString.Contains(term.ToLower()))
                {
                    results.Add(currentItem);
                }
            }
            return results;
        }

        /*
        /// <summary>
        /// Filter by specific menu category that user chooses e.g. entree, side, combo, drink
        /// </summary>
        /// <param name="items"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMenuCategory(List<IMenuItem> items, List<string> filter)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem currentItem in items)
            {
                if (currentItem is Entree && filter.Contains("Entree"))
                {
                    results.Add(currentItem);
                }
                if (currentItem is Drink && filter.Contains("Drink"))
                {
                    results.Add(currentItem);
                }
                if (currentItem is Side && filter.Contains("Side"))
                {
                    results.Add(currentItem);
                }
                if (currentItem is CretaceousCombo && filter.Contains("Combo"))
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }
        */

        /// <summary>
        /// Filters by min price specified by user
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> items, float min)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem currentItem in items)
            {
                if (currentItem.Price >= min)
                {
                    results.Add(currentItem);
                }
            }
            
            return results;
        }

        /// <summary>
        /// Filtesr by max price specified by user
        /// </summary>
        /// <param name="items"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items, float max)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem currentItem in items)
            {
                if (currentItem.Price <= max)
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters by excluded ingredients specified by user
        /// </summary>
        /// <param name="items"></param>
        /// <param name="excludedIngredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByExcludedIngredients(List<IMenuItem> items, List<string> excludedIngredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            bool good = true;
            foreach(IMenuItem currentItem in items)
            {
                foreach(string badIngredient in excludedIngredients)
                {
                    if (currentItem.Ingredients.Contains(badIngredient))
                    {
                        good = false;
                        break;
                    }
                }

                if (good)
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }
    }
}
