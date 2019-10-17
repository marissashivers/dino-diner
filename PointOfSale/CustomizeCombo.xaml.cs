/*  CustomizeCombo.xaml.cs
*   Author: Marissa Shivers
*/
using System;
using System.Windows;
using System.Windows.Controls;
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
        public void Click_DrinkSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DrinkSelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Clicking side selection will nagivate you to the SideSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_SideSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SideSelection.xaml", UriKind.Relative));
        }
    }
}
