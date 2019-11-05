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
    /// Interaction logic for TRexKingBurger_Customize.xaml
    /// </summary>
    public partial class TRexKingBurger_Customize : Page
    {
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public TRexKingBurger_Customize()
        {
            InitializeComponent();
        }

        private void Click_HoldBun(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldBun))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldBun();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldLettuce))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldLettuce();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldTomato(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldTomato))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldTomato();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldOnions(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldOnions))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldOnion();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldMayo(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldMayo))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldMayo();
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
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldMustard();
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
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
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
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                    {
                        burger.HoldKetchup();
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
