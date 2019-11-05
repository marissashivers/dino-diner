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
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public PrehistoricPBJ_Customize()
        {
            InitializeComponent();
        }

        private void Click_HoldPeanutButter(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldPeanutButter))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                    {
                        pbj.HoldPeanutButter();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldJelly(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldJelly))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                    {
                        pbj.HoldJelly();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
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
