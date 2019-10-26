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

        private void Click_FlavorSelection(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_Cherry))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.Cherry;
            }
            if (sender.Equals(Button_Chocolate))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.Chocolate;
            }
            if (sender.Equals(Button_RootBeer))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.RootBeer;
            }
            if (sender.Equals(Button_Lime))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.Lime;
            }
            if (sender.Equals(Button_Orange))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.Orange;
            }
            if (sender.Equals(Button_Vanilla))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.Vanilla;
            }
            if (sender.Equals(Button_Cola))
            {
                DrinkSelection.selectedFlavor = SodasaurusFlavor.Cola;
            }
        }

        public void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = DrinkSelection.selectedFlavor;
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }               
            }
            NavigationService.Navigate(new Uri("/DrinkSelection.xaml", UriKind.Relative));
        }
    }
}
