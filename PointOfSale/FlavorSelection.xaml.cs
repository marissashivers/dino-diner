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
        private Sodasaurus _soda;

        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public FlavorSelection(Sodasaurus soda)
        {
            _soda = soda;
            InitializeComponent();
        }

        private void Click_FlavorSelection(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_Cherry))
            {
                _soda.Flavor = SodasaurusFlavor.Cherry;
            }
            if (sender.Equals(Button_Chocolate))
            {
                _soda.Flavor = SodasaurusFlavor.Chocolate;
            }
            if (sender.Equals(Button_RootBeer))
            {
                _soda.Flavor = SodasaurusFlavor.RootBeer;
            }
            if (sender.Equals(Button_Lime))
            {
                _soda.Flavor = SodasaurusFlavor.Lime;
            }
            if (sender.Equals(Button_Orange))
            {
                _soda.Flavor = SodasaurusFlavor.Orange;
            }
            if (sender.Equals(Button_Vanilla))
            {
                _soda.Flavor = SodasaurusFlavor.Orange;
            }
            if (sender.Equals(Button_Cola))
            {
                _soda.Flavor = SodasaurusFlavor.Cola;
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

