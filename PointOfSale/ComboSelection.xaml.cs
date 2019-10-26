/*  ComboSelection.xaml.cs
*   Author: Marissa Shivers
*/
using System;
using System.Windows;
using System.Windows.Controls;
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
            NavigationService.Navigate(new Uri("/CustomizeCombo.xaml", UriKind.Relative));
        }

        public void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }
    }
}
