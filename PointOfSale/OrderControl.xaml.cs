using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructor for order control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigation service to switch pages
        /// </summary>
        public NavigationService NavigationService { get; set; }

        private void OnRemoveOrderItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
                if (sender is FrameworkElement element)
                    if (element.DataContext is IOrderItem item)
                        order.Remove(item);
        }

        public void OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItems.SelectedItem is Entree entree)
            {
                if (entree is Brontowurst bw) NavigationService.Navigate(new Brontowurst_Customize(bw));
                else if (entree is DinoNuggets dn) NavigationService.Navigate(new DinoNuggets_Customize(dn));
                else if (entree is PrehistoricPBJ pbj) NavigationService.Navigate(new PrehistoricPBJ_Customize(pbj));
                else if (entree is SteakosaurusBurger burger) NavigationService.Navigate(new SteakosaurusBurger_Customize(burger));
                else if (entree is TRexKingBurger tburger) NavigationService.Navigate(new TRexKingBurger_Customize(tburger));
                else if (entree is VelociWrap vw) NavigationService.Navigate(new VelociWrap_Customize(vw));
            }
        }
    }
}
