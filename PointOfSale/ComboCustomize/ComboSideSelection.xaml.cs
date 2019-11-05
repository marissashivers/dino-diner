/*  ComboSideSelection.xaml.cs
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
    public partial class ComboSideSelection : Page
    {
        /// <summary>
        /// Constructor for side selection page
        /// </summary>
        public ComboSideSelection()
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
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("NO entries in back navigation history.");
            }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new Fryceritops();
                }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new MeteorMacAndCheese();
                }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new MezzorellaSticks();
                }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = new Triceritots();
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
