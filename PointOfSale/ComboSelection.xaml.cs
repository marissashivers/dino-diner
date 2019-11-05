/*  ComboSelection.xaml.cs
*   Author: Marissa Shivers
*/
using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When clicking any combo, you are directed to the CustomizeCombo page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_CustomizeCombo(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_BrontowurstCombo))
            {
                if (DataContext is Order order)
                {
                    CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
                    order.Add(combo);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
                }
            }
            else if (sender.Equals(Button_DinoNuggetsCombo))
            {
                if (DataContext is Order order)
                {
                    CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
                    order.Add(combo);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
                }
            }
            else if (sender.Equals(Button_PrehistoricPBJ_Combo))
            {
                if (DataContext is Order order)
                {
                    CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
                    order.Add(combo);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
                }
            }
            else if (sender.Equals(Button_PterodactylWingsCombo))
            {
                if (DataContext is Order order)
                {
                    CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
                    order.Add(combo);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
                }
            }
            else if (sender.Equals(Button_SteakosaurusBurgerCombo))
            {
                if (DataContext is Order order)
                {
                    CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                    order.Add(combo);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
                }
            }
            else if (sender.Equals(Button_VelociWrapCombo))
            {
                if (DataContext is Order order)
                {
                    CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
                    order.Add(combo);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
                }
            }

            // Navigate to Customize Combo Button
            NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
        }

        public void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }
    }
}
