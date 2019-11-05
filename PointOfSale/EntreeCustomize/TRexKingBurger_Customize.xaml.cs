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
    /// Interaction logic for TRexKingBurger_Customize.xaml
    /// </summary>
    public partial class TRexKingBurger_Customize : Page
    {
        private TRexKingBurger _burger;
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public TRexKingBurger_Customize()
        {
            InitializeComponent();
        }

        public TRexKingBurger_Customize(TRexKingBurger burger)
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

        private void Click_HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldLettuce))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldLettuce();
                }
            }
        }

        private void Click_HoldTomato(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldTomato))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldTomato();
                }
            }
        }

        private void Click_HoldOnions(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldOnions))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldOnion();
                }
            }
        }

        private void Click_HoldMayo(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldMayo))
            {
                if (DataContext is Order order)
                {
                    _burger.HoldMayo();
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

        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
