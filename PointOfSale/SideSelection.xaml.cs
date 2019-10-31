/*  SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Constructor for side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Back to main menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Add Fryceritops button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Add_Fryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Fryceritops ft = new Fryceritops();
                order.Add(ft);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Add Mac and Cheese button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Add_MacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                order.Add(mmc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        
        /// <summary>
        /// Add Mezorella sticks button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Add_MozzSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                MezzorellaSticks ms = new MezzorellaSticks();
                order.Add(ms);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Add tator tots button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Add_Tots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Triceritots tots = new Triceritots();
                order.Add(tots);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Make current selected side small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeSmall(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        /// <summary>
        /// Make current selected side medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeMedium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        /// <summary>
        /// Make current selected side large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                // only change size if the item is a side
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        /*
        private void OnCurrentChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    // set radio to side.Size property
                    // Disable selection of new side
                    Button_Fryceritops.IsEnabled = false;
                }
                else
                {
                    Button_Fryceritops.IsEnabled = true;
                }
            }           
        }
        */


    }
}
