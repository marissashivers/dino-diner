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
    public partial class SteakosaurusBurger_Customize : Page
    {
        private SteakosaurusBurger _burger;
        
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public SteakosaurusBurger_Customize()
        {
            InitializeComponent();
        }

        public SteakosaurusBurger_Customize(SteakosaurusBurger burger)
        {
            _burger = burger;
            InitializeComponent();
        }

        private void Click_HoldBun(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldBun))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldBun();
                }
            }
        }

        private void Click_HoldPickle(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldPickle))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldPickle();
                }
            }
        }

        private void Click_HoldKetchup(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldKetchup))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldKetchup();
                }
            }
        }

        private void Click_HoldMustard(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldMustard))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldMustard();
                }
            }
        }

        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
