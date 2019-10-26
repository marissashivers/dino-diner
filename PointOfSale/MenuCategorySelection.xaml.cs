/*  MenuCategorySelection.xaml.cs
*   Author: Marissa Shivers
*/
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Construct for menu category selection page
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the combo button will take you to the ComboSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Combos(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ComboSelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Clicking the Entrees button will navigate you to the EntreeSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Entrees(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }

        private void Button_Click_Sides(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SideSelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Clicking on the Drinks button will navigate you to the DrinkSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Drinks(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DrinkSelection.xaml", UriKind.Relative));
        }
    }
}
