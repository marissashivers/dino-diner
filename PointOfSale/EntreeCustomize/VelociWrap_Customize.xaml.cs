/*  VelociWrap_Customize.xaml.cs
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
    public partial class VelociWrap_Customize : Page
    {
        private VelociWrap _wrap;
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public VelociWrap_Customize()
        {
            InitializeComponent();
        }

        public VelociWrap_Customize(VelociWrap wrap)
        {
            _wrap = wrap;
            InitializeComponent();
        }

        private void Click_HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldLettuce))
            {
                if (DataContext is Order order)
                {
                    _wrap.HoldLettuce();
                }
            }
        }

        private void Click_HoldDressing(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldDressing))
            {
                if (DataContext is Order order)
                {
                    _wrap.HoldDressing();
                }
            }
        }

        private void Click_HoldCheese(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldCheese))
            {
                if (DataContext is Order order)
                {
                    _wrap.HoldCheese();
                }
            }
        }

        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
