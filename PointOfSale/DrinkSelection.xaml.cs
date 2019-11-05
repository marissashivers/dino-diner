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

        /// <summary>
        /// Constructor for DrinkSelection page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking on soda will add the "choose flavor" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Soda(object sender, RoutedEventArgs e)
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
            sp2.Children.Add(removeIce);

            if (DataContext is Order order)
            {
                Sodasaurus soda = new Sodasaurus();
                order.Add(soda);
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
            addSweetener.Click += Click_Sweetener;
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

            // ADD TEA TO THE CURRENT ORDER LIST
            if (DataContext is Order order)
            {
                Tyrannotea tea = new Tyrannotea();
                order.Add(tea);
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
            addCream.Click += Click_Cream;
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


            // ADD JAVA TO CURRENT ORDER
            if (DataContext is Order order)
            {
                JurassicJava java = new JurassicJava();
                order.Add(java);
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
            sp1.Children.Add(removeIce);

            // Add lemon button
            Button addLemon = new Button();
            addLemon.SetValue(Grid.RowProperty, 1);
            addLemon.SetValue(Grid.ColumnProperty, 2);
            addLemon.Height = 88;

            addLemon.Content = "Add lemon";
            addLemon.FontSize = 20;
            addLemon.Click += Click_Lemon;
            sp2.Children.Add(addLemon);

            // ADD TO ORDER
            if (DataContext is Order order)
            {
                Water w = new Water();
                order.Add(w);
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
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
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
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        /// <summary>
        /// Change currently selected drink to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Large(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
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
                NavigationService.Navigate(new Uri("/FlavorSelection.xaml", UriKind.Relative));
            }
        }

        /// <summary>
        /// Button for adding sweetener to Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Sweetener(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.AddSweetener();
                }
            }
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
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water w)
                {
                    w.AddLemon();
                }
            }
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
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.Decaf = true;
                }
            }
        }

        /// <summary>
        /// Button for adding cream to Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Cream(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.LeaveRoomForCream();
                }
            }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.HoldIce();
                }
            }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.AddIce();
                }
            }
        }

        /// <summary>
        /// Button for navigating back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
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
}
