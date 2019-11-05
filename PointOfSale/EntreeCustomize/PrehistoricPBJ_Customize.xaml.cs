/*  PrehistoricPBJ_Customize.xaml.cs
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
    /// Interaction logic for PrehistoricPBJ_Customize.xaml
    /// </summary>
    public partial class PrehistoricPBJ_Customize : Page
    {
        private PrehistoricPBJ _pbj;

        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public PrehistoricPBJ_Customize()
        {
            InitializeComponent();
        }
        
        public PrehistoricPBJ_Customize(PrehistoricPBJ pbj)
        {
            _pbj = pbj;
            InitializeComponent();
        }

        private void Click_HoldPeanutButter(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldPeanutButter))
            {
                if (DataContext is Order order)
                {
                    _pbj.HoldPeanutButter();
                }
            }
        }

        private void Click_HoldJelly(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldJelly))
            {
                if (DataContext is Order order)
                {
                    _pbj.HoldJelly();
                }
            }
        }

        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
