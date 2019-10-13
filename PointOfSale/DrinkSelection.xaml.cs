using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking on soda will take you to the flavor selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_Soda(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FlavorSelection.xaml", UriKind.Relative));
        }
    }
}
