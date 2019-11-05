/*  CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking drink selection will navigate you to the DrinkSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_DrinkSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ComboCustomize/ComboDrinkSelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Clicking side selection will nagivate you to the SideSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_SideSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ComboCustomize/ComboSideSelection.xaml", UriKind.Relative));
        }

        private void Click_CustomizeEntree(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst)
                    {
                        NavigationService.Navigate(new Uri("EntreeCustomize/Brontowurst_Customize.xaml", UriKind.Relative));
                    }
                }


                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/Brontowurst_Customize.xaml", UriKind.Relative));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/DinoNuggets_Customize.xaml", UriKind.Relative));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/PrehistoricPBJ_Customize.xaml", UriKind.Relative));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PterodactylWings)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/PterodactylWings_Customize.xaml", UriKind.Relative));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/SteakosaurusBurger_Customize.xaml", UriKind.Relative));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/TRexKingBurger_Customize.xaml", UriKind.Relative));
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap)
                {
                    NavigationService.Navigate(new Uri("EntreeCustomize/VelociWrap_Customize.xaml", UriKind.Relative));
                }
            }
        }

        private void Click_MakeSmall(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        private void Click_MakeMedium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }
        private void Click_MakeLarge(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }
        
        private void Click_Back(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_Back))
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
            else if (sender.Equals(Button_BackToMainMenu))
            {
                NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
            }

        }

    }
}
