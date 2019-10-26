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
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        private DinoDiner.Menu.SodasaurusFlavor selectedFlavor;

        private void Click_FlavorSelection(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_Cherry))
            {
                selectedFlavor = SodasaurusFlavor.Cherry;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
            if (sender.Equals(Button_Chocolate))
            {
                selectedFlavor = SodasaurusFlavor.Chocolate;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
            if (sender.Equals(Button_RootBeer))
            {
                selectedFlavor = SodasaurusFlavor.RootBeer;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
            if (sender.Equals(Button_Lime))
            {
                selectedFlavor = SodasaurusFlavor.Lime;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
            if (sender.Equals(Button_Orange))
            {
                selectedFlavor = SodasaurusFlavor.Orange;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
            if (sender.Equals(Button_Vanilla))
            {
                selectedFlavor = SodasaurusFlavor.Vanilla;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
            if (sender.Equals(Button_Cola))
            {
                selectedFlavor = SodasaurusFlavor.Cola;
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.Flavor = selectedFlavor;
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        public void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DrinkSelection.xaml", UriKind.Relative));
        }
    }
}
