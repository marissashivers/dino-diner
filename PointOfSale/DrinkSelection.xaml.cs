/*  DrinkSelection.xaml.cs
*   Author: Marissa Shivers
*/
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {

        private Drink _drink = null;
        private CretaceousCombo _combo = null;

        private bool isDrink = false;
        private bool isCombo = false;

        /// <summary>
        /// Constructor for DrinkSelection page
        /// </summary>
        public DrinkSelection()
        {
            isDrink = true;
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            _drink = drink;
            isDrink = true;
            InitializeComponent();

            if (_drink is Water) SetWaterButtons();
            else if (_drink is Sodasaurus) SetSodaButtons();
            else if (_drink is JurassicJava) SetJavaButtons();
            else if (_drink is Tyrannotea) SetTeaButtons();
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            _combo = combo;
            isCombo = true;
            InitializeComponent();

            if (_combo.Drink is Water) SetWaterButtons();
            else if (_combo.Drink is Sodasaurus) SetSodaButtons();
            else if (_combo.Drink is JurassicJava) SetJavaButtons();
            else if (_combo.Drink is Tyrannotea) SetTeaButtons();

            Button_Small.IsEnabled = false;
            Button_Medium.IsEnabled = false;
            Button_Large.IsEnabled = false;
        }

        /// <summary>
        /// Clicking on soda will add the "choose flavor" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Soda(object sender, RoutedEventArgs e)
        {
            SetSodaButtons();

            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    Sodasaurus soda = new Sodasaurus();
                    _drink = soda;
                    order.Add(_drink);
                }
                else if (isCombo)
                {
                    _combo.Drink = new Sodasaurus();
                }

            }

        }

        /// <summary>
        /// Button for adding tea
        /// Creates sweetener, lemon, and remove ice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Tea(object sender, RoutedEventArgs e)
        {
            SetTeaButtons();

            // ADD TEA TO THE CURRENT ORDER LIST
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    Tyrannotea tea = new Tyrannotea();
                    _drink = tea;
                    order.Add(_drink);
                }
                else if (isCombo)
                {
                    _combo.Drink = new Tyrannotea();
                }

            }

        }


        /// <summary>
        /// Button for adding Jurassic Java
        /// Includes adding decaf, cream, and ice buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Coffee(object sender, RoutedEventArgs e)
        {
            SetJavaButtons();

            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    JurassicJava java = new JurassicJava();
                    _drink = java;
                    order.Add(_drink);
                }
                else if (isCombo)
                {
                    _combo.Drink = new JurassicJava();
                }
            }

        }

        /// <summary>
        /// Button for adding water
        /// Creates remove ice and add lemon button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Water(object sender, RoutedEventArgs e)
        {
            SetWaterButtons();

            // ADD TO ORDER
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    Water w = new Water();
                    _drink = w;
                    order.Add(_drink);
                }
                else if (isCombo)
                {
                    _combo.Drink = new Water();
                }
            }
        }

        // ***************** Sizes ***********************************************
        /// <summary>
        /// Change currently selected drink to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Small(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (isDrink)
                {
                    if (_drink != null) _drink.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        /// <summary>
        /// Change currently selected drink to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Medium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (_drink != null) _drink.Size = DinoDiner.Menu.Size.Medium;
            }
        }

        /// <summary>
        /// Change currently selected drink to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Large(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (_drink != null) _drink.Size = DinoDiner.Menu.Size.Large;
            }
        }


        // **************** Special buttons ************************************************
        /// <summary>
        /// Choose flavor button for Sodasaurus. Navigates to flavor selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Choose_Flavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (isDrink)
                {
                    NavigationService.Navigate(new FlavorSelection(_drink as Sodasaurus));
                }
                else if (isCombo)
                {
                    NavigationService.Navigate(new FlavorSelection(_combo));
                }
            }
        }

        /// <summary>
        /// Button for adding sweetener to Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Add_Sweetener(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (isDrink)
                {
                    if (_drink is Tyrannotea tea)
                    {
                        tea.AddSweetener();
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is Tyrannotea tea)
                    {
                        tea.AddSweetener();
                    }
                }
            }
            // Remove "add sweetener" button and add "remove sweetener" button
            // Remove "remove sweetener" button and add "add sweetener" button
            sp1.Children.Clear();
            // Add sweetener button
            Button removeSweetener = new Button();
            removeSweetener.SetValue(Grid.RowProperty, 1);
            removeSweetener.SetValue(Grid.ColumnProperty, 2);
            removeSweetener.Height = 88;

            removeSweetener.Content = "Remove sweetener";
            removeSweetener.FontSize = 20;
            removeSweetener.Click += Click_Remove_Sweetener;
            sp1.Children.Add(removeSweetener);
        }

        private void Click_Remove_Sweetener(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (isDrink)
                {
                    if (_drink is Tyrannotea tea)
                    {
                        tea.RemoveSweetener();
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is Tyrannotea tea)
                    {
                        tea.RemoveSweetener();
                    }
                }
            }
            // Remove "remove sweetener" button and add "add sweetener" button
            sp1.Children.Clear();
            // Add sweetener button
            Button addSweetener = new Button();
            addSweetener.SetValue(Grid.RowProperty, 1);
            addSweetener.SetValue(Grid.ColumnProperty, 2);
            addSweetener.Height = 88;

            addSweetener.Content = "Add sweetener";
            addSweetener.FontSize = 20;
            addSweetener.Click += Click_Add_Sweetener;
            sp1.Children.Add(addSweetener);
        }

        /// <summary>
        /// Button for adding lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Lemon(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    if (_drink is Tyrannotea tea)
                    {
                        tea.AddLemon();
                    }
                    else if (_drink is Water water)
                    {
                        water.AddLemon();
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is Tyrannotea tea)
                    {
                        tea.AddLemon();
                    }
                    else if (_combo.Drink is Water w)
                    {
                        w.AddLemon();
                    }
                }
            }
            // Remove "add lemon" button and add "remove lemon" button
            sp2.Children.Clear();
            // Add "remove lemon" button
            Button removeLemon = new Button();
            removeLemon.SetValue(Grid.RowProperty, 1);
            removeLemon.SetValue(Grid.ColumnProperty, 2);
            removeLemon.Height = 88;

            removeLemon.Content = "Remove lemon";
            removeLemon.FontSize = 20;
            removeLemon.Click += Click_Remove_Lemon;
            sp2.Children.Add(removeLemon);
        }

        private void Click_Remove_Lemon(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    if (_drink is Tyrannotea tea)
                    {
                        tea.RemoveLemon();
                    }
                    else if (_drink is Water water)
                    {
                        water.RemoveLemon();
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is Tyrannotea tea)
                    {
                        tea.RemoveLemon();
                    }
                    else if (_combo.Drink is Water w)
                    {
                        w.RemoveLemon();
                    }
                }
            }

            // Remove "remove lemon" button and add "add lemon" button
            sp2.Children.Clear();
            // Add lemon button
            Button addLemon = new Button();
            addLemon.SetValue(Grid.RowProperty, 1);
            addLemon.SetValue(Grid.ColumnProperty, 2);
            addLemon.Height = 88;

            addLemon.Content = "Add lemon";
            addLemon.FontSize = 20;
            addLemon.Click += Click_Lemon;
            sp2.Children.Add(addLemon);
        }

        /// <summary>
        /// Button for making JurassicJava decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Decaf(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    if (_drink is JurassicJava java)
                    {
                        java.Decaf = true;
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is JurassicJava java)
                    {
                        java.Decaf = true;
                    }
                }
            }

            sp1.Children.Clear();
            Button makeNonDecaf = new Button();
            makeNonDecaf.SetValue(Grid.RowProperty, 1);
            makeNonDecaf.SetValue(Grid.ColumnProperty, 2);
            makeNonDecaf.Height = 88;

            makeNonDecaf.Content = "Make regular";
            makeNonDecaf.FontSize = 20;
            makeNonDecaf.Click += Click_NonDecaf;
            sp1.Children.Add(makeNonDecaf);
        }

        private void Click_NonDecaf(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    if (_drink is JurassicJava java)
                    {
                        java.Decaf = false;
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is JurassicJava java)
                    {
                        java.Decaf = false;
                    }
                }
            }

            sp1.Children.Clear();
            // Make decaf button
            Button makeDecaf = new Button();
            makeDecaf.SetValue(Grid.RowProperty, 1);
            makeDecaf.SetValue(Grid.ColumnProperty, 2);
            makeDecaf.Height = 88;

            makeDecaf.Content = "Make decaf";
            makeDecaf.FontSize = 20;
            makeDecaf.Click += Click_Decaf;
            sp1.Children.Add(makeDecaf);
        }

        /// <summary>
        /// Button for adding cream to Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Add_Cream(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    if (_drink is JurassicJava java)
                    {
                        java.LeaveRoomForCream();
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is JurassicJava java)
                    {
                        java.LeaveRoomForCream();
                    }
                }
            }

            sp2.Children.Clear();
            // Remove cream button
            Button removeCream = new Button();
            removeCream.SetValue(Grid.RowProperty, 1);
            removeCream.SetValue(Grid.ColumnProperty, 2);
            removeCream.Height = 88;

            removeCream.Content = "Remove cream";
            removeCream.FontSize = 20;
            removeCream.Click += Click_Remove_Cream;
            sp2.Children.Add(removeCream);
        }

        private void Click_Remove_Cream(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    if (_drink is JurassicJava java)
                    {
                        java.RemoveCream();
                    }
                }
                else if (isCombo)
                {
                    if (_combo.Drink is JurassicJava java)
                    {
                        java.RemoveCream();
                    }
                }
            }

            sp2.Children.Clear();
            // Add cream button
            Button addCream = new Button();
            addCream.SetValue(Grid.RowProperty, 1);
            addCream.SetValue(Grid.ColumnProperty, 2);
            addCream.Height = 88;

            addCream.Content = "Add cream";
            addCream.FontSize = 20;
            addCream.Click += Click_Add_Cream;
            sp2.Children.Add(addCream);
        }

        /// <summary>
        /// Button for removing ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_RemoveIce(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                    _drink.HoldIce();
                }
                else if (isCombo)
                {
                    _combo.Drink.HoldIce();
                }
            }

            sp3.Children.Clear();
            // Add ice button
            Button addIce = new Button();
            addIce.SetValue(Grid.RowProperty, 1);
            addIce.SetValue(Grid.ColumnProperty, 2);
            addIce.Height = 88;

            addIce.Content = "Add Ice";
            addIce.FontSize = 20;
            addIce.Click += Click_AddIce;
            sp3.Children.Add(addIce);
        }

        /// <summary>
        /// Button for adding ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_AddIce(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (isDrink)
                {
                   _drink.AddIce();
                }
                else if (isCombo)
                {
                    _combo.Drink.AddIce();
                }
            }

            sp3.Children.Clear();
            // Remove "add ice" button and add "remove ice" button
            Button removeIce = new Button();
            removeIce.SetValue(Grid.RowProperty, 1);
            removeIce.SetValue(Grid.ColumnProperty, 2);
            removeIce.Height = 88;

            removeIce.Content = "Remove Ice";
            removeIce.FontSize = 20;
            removeIce.Click += Click_RemoveIce;
            sp3.Children.Add(removeIce);
        }

        /// <summary>
        /// Button for navigating back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            if (isDrink)
            {
                if (this.NavigationService.CanGoBack)
                {
                    NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("NO entries in back navigation history.");
                }
            }
            else if (isCombo)
            {
                if (this.NavigationService.CanGoBack)
                {
                    this.NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("NO entries in back navigation history.");
                }
            }
        }

        private void SetSodaButtons()
        {
            sp1.Children.Clear();
            sp2.Children.Clear();
            sp3.Children.Clear();

            // Choose flavor button
            Button chooseFlavor = new Button();
            chooseFlavor.SetValue(Grid.RowProperty, 1);
            chooseFlavor.SetValue(Grid.ColumnProperty, 2);
            chooseFlavor.Height = 88;

            chooseFlavor.Content = "Choose Flavor";
            chooseFlavor.FontSize = 20;
            chooseFlavor.Click += Click_Choose_Flavor;
            sp1.Children.Add(chooseFlavor);

            Button removeIce = new Button();
            removeIce.SetValue(Grid.RowProperty, 1);
            removeIce.SetValue(Grid.ColumnProperty, 2);
            removeIce.Height = 88;

            removeIce.Content = "Remove Ice";
            removeIce.FontSize = 20;
            removeIce.Click += Click_RemoveIce;
            sp3.Children.Add(removeIce);
        }

        private void SetTeaButtons()
        {
            sp1.Children.Clear();
            sp2.Children.Clear();
            sp3.Children.Clear();

            // Add sweetener button
            Button addSweetener = new Button();
            addSweetener.SetValue(Grid.RowProperty, 1);
            addSweetener.SetValue(Grid.ColumnProperty, 2);
            addSweetener.Height = 88;

            addSweetener.Content = "Add sweetener";
            addSweetener.FontSize = 20;
            addSweetener.Click += Click_Add_Sweetener;
            sp1.Children.Add(addSweetener);

            // Add lemon button
            Button addLemon = new Button();
            addLemon.SetValue(Grid.RowProperty, 1);
            addLemon.SetValue(Grid.ColumnProperty, 2);
            addLemon.Height = 88;

            addLemon.Content = "Add lemon";
            addLemon.FontSize = 20;
            addLemon.Click += Click_Lemon;
            sp2.Children.Add(addLemon);

            // Remove ice button
            Button removeIce = new Button();
            removeIce.SetValue(Grid.RowProperty, 1);
            removeIce.SetValue(Grid.ColumnProperty, 2);
            removeIce.Height = 88;

            removeIce.Content = "Remove Ice";
            removeIce.FontSize = 20;
            removeIce.Click += Click_RemoveIce;
            sp3.Children.Add(removeIce);
        }

        private void SetJavaButtons()
        {
            sp1.Children.Clear();
            sp2.Children.Clear();
            sp3.Children.Clear();

            // Make decaf button
            Button makeDecaf = new Button();
            makeDecaf.SetValue(Grid.RowProperty, 1);
            makeDecaf.SetValue(Grid.ColumnProperty, 2);
            makeDecaf.Height = 88;

            makeDecaf.Content = "Make decaf";
            makeDecaf.FontSize = 20;
            makeDecaf.Click += Click_Decaf;
            sp1.Children.Add(makeDecaf);

            // Add cream button
            Button addCream = new Button();
            addCream.SetValue(Grid.RowProperty, 1);
            addCream.SetValue(Grid.ColumnProperty, 2);
            addCream.Height = 88;

            addCream.Content = "Add cream";
            addCream.FontSize = 20;
            addCream.Click += Click_Add_Cream;
            sp2.Children.Add(addCream);

            // Add ice button
            Button addIce = new Button();
            addIce.SetValue(Grid.RowProperty, 1);
            addIce.SetValue(Grid.ColumnProperty, 2);
            addIce.Height = 88;

            addIce.Content = "Add Ice";
            addIce.FontSize = 20;
            addIce.Click += Click_AddIce;
            sp3.Children.Add(addIce);
        }

        private void SetWaterButtons()
        {
            sp1.Children.Clear();
            sp2.Children.Clear();
            sp3.Children.Clear();

            // Remove ice button
            Button removeIce = new Button();
            removeIce.SetValue(Grid.RowProperty, 1);
            removeIce.SetValue(Grid.ColumnProperty, 2);
            removeIce.Height = 88;

            removeIce.Content = "Remove Ice";
            removeIce.FontSize = 20;
            removeIce.Click += Click_RemoveIce;
            sp3.Children.Add(removeIce);

            // Add lemon button
            Button addLemon = new Button();
            addLemon.SetValue(Grid.RowProperty, 1);
            addLemon.SetValue(Grid.ColumnProperty, 2);
            addLemon.Height = 88;

            addLemon.Content = "Add lemon";
            addLemon.FontSize = 20;
            addLemon.Click += Click_Lemon;
            sp2.Children.Add(addLemon);
        }
    }
}
