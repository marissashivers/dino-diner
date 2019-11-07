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
        private Side _side = null;
        private CretaceousCombo _combo = null;

        private bool isSide = false;
        private bool isCombo = false;

        /// <summary>
        /// Constructor for side selection page
        /// </summary>
        public SideSelection()
        {
            isSide = true;
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            _side = side;
            isSide = true;
            InitializeComponent();
        }

        public SideSelection(CretaceousCombo combo)
        {
            _combo = combo;
            isCombo = true;
            InitializeComponent();
            Button_Small.IsEnabled = false;
            Button_Medium.IsEnabled = false;
            Button_Large.IsEnabled = false;
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
                if (isSide)
                {
                    Fryceritops ft = new Fryceritops();
                    _side = ft;
                    order.Add(_side);
                }
                else if (isCombo)
                {
                    _combo.Side = new Fryceritops();
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
                if (isSide)
                {
                    MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                    _side = mmc;
                    order.Add(_side);
                }
                else if (isCombo)
                {
                    _combo.Side = new MeteorMacAndCheese();
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
                if (isSide)
                {
                    MezzorellaSticks ms = new MezzorellaSticks();
                    _side = ms;
                    order.Add(_side);
                }
                else if (isCombo)
                {
                    _combo.Side = new MeteorMacAndCheese();
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
                if (isSide)
                {
                    Triceritots tots = new Triceritots();
                    _side = tots;
                    order.Add(_side);
                }
                else if (isCombo)
                {
                    _combo.Side = new Triceritots();
                }
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
                if (_side != null) _side.Size = DinoDiner.Menu.Size.Small;
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
                if (_side != null) _side.Size = DinoDiner.Menu.Size.Medium;
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
                if (_side != null) _side.Size = DinoDiner.Menu.Size.Large;
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
