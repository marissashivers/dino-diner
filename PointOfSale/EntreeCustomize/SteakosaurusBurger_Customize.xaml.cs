/*  FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class SteakosaurusBurger_Customize : Page
    {
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public SteakosaurusBurger_Customize()
        {
            InitializeComponent();
        }

        private void Click_HoldBun(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldBun))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger burger)
                    {
                        burger.HoldBun();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldPickle(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldPickle))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger burger)
                    {
                        burger.HoldPickle();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldKetchup(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldKetchup))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger burger)
                    {
                        burger.HoldKetchup();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldMustard(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldMustard))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger burger)
                    {
                        burger.HoldMustard();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }


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
            //NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
