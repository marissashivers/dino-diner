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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking drink selection will navigate you to the DrinkSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_DrinkSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DrinkSelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Clicking side selection will nagivate you to the SideSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_SideSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SideSelection.xaml", UriKind.Relative));
        }
    }
}
