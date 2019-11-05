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
    public partial class Brontowurst_Customize : Page
    {
        private Brontowurst _brontowurst;

        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public Brontowurst_Customize()
        {
            InitializeComponent();
        }

        public Brontowurst_Customize(Brontowurst bw)
        {
            _brontowurst = bw;
            InitializeComponent();
        }

        private void Click_HoldBun(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldBun))
            {
                if (DataContext is Order order)
                {
                    _brontowurst.HoldBun();
                }
            }
        }

        private void Click_HoldOnions(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldOnions))
            {
                if (DataContext is Order order)
                {
                    _brontowurst.HoldOnion();
                }
            }
        }

        private void Click_HoldPeppers(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldPeppers))
            {
                if (DataContext is Order order)
                {
                    _brontowurst.HoldPeppers();
                }
            }
        }

        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
