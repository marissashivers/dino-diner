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
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public VelociWrap_Customize()
        {
            InitializeComponent();
        }

        private void Click_HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldLettuce))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                    {
                        wrap.HoldLettuce();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldDressing(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldDressing))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                    {
                        wrap.HoldDressing();
                        CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    }
                }
            }
        }

        private void Click_HoldCheese(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_HoldCheese))
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                    {
                        wrap.HoldCheese();
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
