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
        private Sodasaurus _soda = null;
        private CretaceousCombo _combo = null;

        private bool isSoda = false;
        private bool isCombo = false;

        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public FlavorSelection()
        {
            isSoda = true;
            InitializeComponent();
        }

        public FlavorSelection(Sodasaurus soda)
        {
            _soda = soda;
            isSoda = true;
            InitializeComponent();
        }

        public FlavorSelection(CretaceousCombo combo)
        {
            _combo = combo;
            isCombo = true;
            InitializeComponent();
        }

        private void Click_FlavorSelection(object sender, RoutedEventArgs e)
        {
            if (isSoda)
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
                    _soda.Flavor = SodasaurusFlavor.Vanilla;
                }
                if (sender.Equals(Button_Cola))
                {
                    _soda.Flavor = SodasaurusFlavor.Cola;
                }
            }
            else if (isCombo)
            {
                if (sender.Equals(Button_Cherry))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.Cherry;
                }
                if (sender.Equals(Button_Chocolate))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.Chocolate;
                }
                if (sender.Equals(Button_RootBeer))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.RootBeer;
                }
                if (sender.Equals(Button_Lime))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.Lime;
                }
                if (sender.Equals(Button_Orange))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.Orange;
                }
                if (sender.Equals(Button_Vanilla))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.Vanilla;
                }
                if (sender.Equals(Button_Cola))
                {
                    Sodasaurus _soda = (Sodasaurus)_combo.Drink;
                    _soda.Flavor = SodasaurusFlavor.Cola;
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

