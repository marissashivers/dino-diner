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
        private CretaceousCombo _combo;
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public CustomizeCombo(CretaceousCombo combo)
        {
            _combo = combo;
            InitializeComponent();
        }

        /// <summary>
        /// Clicking drink selection will navigate you to the DrinkSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_DrinkSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboDrinkSelection(_combo));
        }

        /// <summary>
        /// Clicking side selection will nagivate you to the SideSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_SideSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSideSelection(_combo));
        }

        private void Click_CustomizeEntree(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (_combo.Entree is Brontowurst)
                {
                    NavigationService.Navigate(new Brontowurst_Customize(_combo.Entree as Brontowurst));
                }
                if (_combo.Entree is DinoNuggets)
                {
                    NavigationService.Navigate(new DinoNuggets_Customize(_combo.Entree as DinoNuggets));
                }
                if (_combo.Entree is PrehistoricPBJ)
                {
                    NavigationService.Navigate(new PrehistoricPBJ_Customize(_combo.Entree as PrehistoricPBJ));
                }
                if (_combo.Entree is SteakosaurusBurger)
                {
                    NavigationService.Navigate(new SteakosaurusBurger_Customize(_combo.Entree as SteakosaurusBurger));
                }
                if (_combo.Entree is TRexKingBurger)
                {
                    NavigationService.Navigate(new TRexKingBurger_Customize(_combo.Entree as TRexKingBurger));
                }
                if (_combo.Entree is VelociWrap)
                {
                    NavigationService.Navigate(new VelociWrap_Customize(_combo.Entree as VelociWrap));
                }
            }
        }

        private void Click_MakeSmall(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                _combo.Size = DinoDiner.Menu.Size.Small;
            }
        }

        private void Click_MakeMedium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                _combo.Size = DinoDiner.Menu.Size.Medium;
            }
        }
        private void Click_MakeLarge(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                _combo.Size = DinoDiner.Menu.Size.Large;
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
