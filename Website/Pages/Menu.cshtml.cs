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
                Menu.AvailableCombos = Menu.Search(Menu.AvailableCombos, search);
                Menu.AvailableEntrees = Menu.Search(Menu.AvailableEntrees, search);
                Menu.AvailableSides = Menu.Search(Menu.AvailableSides, search);
                Menu.AvailableDrinks = Menu.Search(Menu.AvailableDrinks, search);
            }

            // filter by menu category???
            if (menuCategory.Count > 0)
            {
                Menu.AvailableCombos = Menu.FilterByMenuCategory(Menu.AvailableCombos, menuCategory);
                Menu.AvailableEntrees = Menu.FilterByMenuCategory(Menu.AvailableEntrees, menuCategory);
                Menu.AvailableSides = Menu.FilterByMenuCategory(Menu.AvailableSides, menuCategory);
                Menu.AvailableDrinks = Menu.FilterByMenuCategory(Menu.AvailableDrinks, menuCategory);
            }

            // min price
            if (minimumPrice is float min)
            {
                Menu.AvailableCombos = Menu.FilterByMinPrice(Menu.AvailableCombos, min);
                Menu.AvailableEntrees = Menu.FilterByMinPrice(Menu.AvailableEntrees, min);
                Menu.AvailableMenuItems = Menu.FilterByMinPrice(Menu.AvailableMenuItems, min);
                Menu.AvailableSides = Menu.FilterByMinPrice(Menu.AvailableSides, min);
            }

            // max price
            if (maximumPrice is float max)
            {
                Menu.AvailableCombos = Menu.FilterByMaxPrice(Menu.AvailableCombos, max);
                Menu.AvailableEntrees = Menu.FilterByMaxPrice(Menu.AvailableEntrees, max);
                Menu.AvailableMenuItems = Menu.FilterByMaxPrice(Menu.AvailableMenuItems, max);
                Menu.AvailableSides = Menu.FilterByMaxPrice(Menu.AvailableSides, max);
            }

            // filter by excluded ingredients
            if (excludedIngredients.Count > 0)
            {
                Menu.AvailableCombos = Menu.FilterByExcludedIngredients(Menu.AvailableCombos, excludedIngredients);
                Menu.AvailableEntrees = Menu.FilterByExcludedIngredients(Menu.AvailableEntrees, excludedIngredients);
                Menu.AvailableSides = Menu.FilterByExcludedIngredients(Menu.AvailableSides, excludedIngredients);
                Menu.AvailableDrinks = Menu.FilterByExcludedIngredients(Menu.AvailableDrinks, excludedIngredients);
            }
        }
    }
}