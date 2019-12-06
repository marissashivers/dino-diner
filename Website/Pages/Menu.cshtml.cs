using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; set; }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        public void OnGet()
        {
            Menu = new Menu();
        }

        public void OnPost()
        {
            Menu = new Menu();
            if (search != null)
            {
                //Menu.AvailableCombos = Menu.Search(Menu.AvailableCombos, search);
                Menu.AvailableCombos = Menu.AvailableCombos.Where(menuItem => menuItem is CretaceousCombo && menuItem.ToString().ToLower().Contains(search.ToLower())).ToList();

                //Menu.AvailableEntrees = Menu.Search(Menu.AvailableEntrees, search);
                Menu.AvailableEntrees = Menu.AvailableEntrees.Where(menuItem => menuItem is Entree && menuItem.ToString().ToLower().Contains(search.ToLower())).ToList();

                //Menu.AvailableSides = Menu.Search(Menu.AvailableSides, search);
                Menu.AvailableSides = Menu.AvailableSides.Where(menuItem => menuItem is Side && menuItem.ToString().ToLower().Contains(search.ToLower())).ToList();

                //Menu.AvailableDrinks = Menu.Search(Menu.AvailableDrinks, search);
                Menu.AvailableDrinks = Menu.AvailableDrinks.Where(menuItem => menuItem is Drink && menuItem.ToString().ToLower().Contains(search.ToLower())).ToList();
            }

            // filter by menu category
            if (menuCategory.Count > 0)
            {
                //Menu.AvailableCombos = Menu.FilterByMenuCategory(Menu.AvailableCombos, menuCategory);
                Menu.AvailableCombos = (Menu.AvailableCombos.Where(menuItem => menuItem is CretaceousCombo && menuCategory.Contains("Combo"))).ToList();

                //Menu.AvailableEntrees = Menu.FilterByMenuCategory(Menu.AvailableEntrees, menuCategory);
                Menu.AvailableEntrees = (Menu.AvailableEntrees.Where(menuItem => menuItem is Entree && menuCategory.Contains("Entree"))).ToList();

                //Menu.AvailableSides = Menu.FilterByMenuCategory(Menu.AvailableSides, menuCategory);
                Menu.AvailableSides = (Menu.AvailableSides.Where(menuItem => menuItem is Side && menuCategory.Contains("Side"))).ToList();

                //Menu.AvailableDrinks = Menu.FilterByMenuCategory(Menu.AvailableDrinks, menuCategory);
                Menu.AvailableDrinks = (Menu.AvailableDrinks.Where(menuItem => menuItem is Drink && menuCategory.Contains("Drink"))).ToList();
            }

            // min price
            if (minimumPrice is float min)
            {
                //Menu.AvailableCombos = Menu.FilterByMinPrice(Menu.AvailableCombos, min);
                Menu.AvailableCombos = (Menu.AvailableCombos.Where(menuItem => menuItem is CretaceousCombo && menuItem.Price >= min)).ToList();

                //Menu.AvailableEntrees = Menu.FilterByMinPrice(Menu.AvailableEntrees, min);
                Menu.AvailableEntrees = (Menu.AvailableEntrees.Where(menuItem => menuItem is Entree && menuItem.Price >= min)).ToList();

                //Menu.AvailableMenuItems = Menu.FilterByMinPrice(Menu.AvailableMenuItems, min);
                Menu.AvailableDrinks = (Menu.AvailableDrinks.Where(menuItem => menuItem is Drink && menuItem.Price >= min)).ToList();

                //Menu.AvailableSides = Menu.FilterByMinPrice(Menu.AvailableSides, min);
                Menu.AvailableSides = (Menu.AvailableSides.Where(menuItem => menuItem is Side && menuItem.Price >= min)).ToList();
            }

            // max price
            if (maximumPrice is float max)
            {
                //Menu.AvailableCombos = Menu.FilterByMaxPrice(Menu.AvailableCombos, max);
                Menu.AvailableCombos = Menu.AvailableCombos.Where((menuItem => menuItem is CretaceousCombo && menuItem.Price <= max)).ToList();

                //Menu.AvailableEntrees = Menu.FilterByMaxPrice(Menu.AvailableEntrees, max);
                Menu.AvailableEntrees = Menu.AvailableEntrees.Where((menuItem => menuItem is Entree && menuItem.Price <= max)).ToList();

                //Menu = Menu.FilterByMaxPrice(Menu.AvailableMenuItems, max);
                Menu.AvailableDrinks = Menu.AvailableDrinks.Where((menuItem => menuItem is Drink && menuItem.Price <= max)).ToList();

                //Menu.AvailableSides = Menu.FilterByMaxPrice(Menu.AvailableSides, max);
                Menu.AvailableSides = Menu.AvailableSides.Where((menuItem => menuItem is Side && menuItem.Price <= max)).ToList();
            }

            // filter by excluded ingredients
            if (excludedIngredients.Count > 0)
            {
                //Menu.AvailableCombos = Menu.FilterByExcludedIngredients(Menu.AvailableCombos, excludedIngredients);
                Menu.AvailableCombos = Menu.AvailableCombos.Where(menuItem => menuItem is CretaceousCombo 
                    && excludedIngredients.All(ingredient => !menuItem.Ingredients.Contains(ingredient))).ToList();

                //Menu.AvailableEntrees = Menu.FilterByExcludedIngredients(Menu.AvailableEntrees, excludedIngredients);
                Menu.AvailableEntrees = Menu.AvailableEntrees.Where(menuItem => menuItem is Entree
                    && excludedIngredients.All(ingredient => !menuItem.Ingredients.Contains(ingredient))).ToList();

                //Menu.AvailableSides = Menu.FilterByExcludedIngredients(Menu.AvailableSides, excludedIngredients);
                Menu.AvailableSides = Menu.AvailableSides.Where(menuItem => menuItem is Side
                    && excludedIngredients.All(ingredient => !menuItem.Ingredients.Contains(ingredient))).ToList();

                //Menu.AvailableDrinks = Menu.FilterByExcludedIngredients(Menu.AvailableDrinks, excludedIngredients);
                Menu.AvailableDrinks = Menu.AvailableDrinks.Where(menuItem => menuItem is Drink
                    && excludedIngredients.All(ingredient => !menuItem.Ingredients.Contains(ingredient))).ToList();
            }
        }
    }
}