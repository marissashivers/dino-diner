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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        private void Button_Click_Combos(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ComboSelection.xaml", UriKind.Relative));
        }

        private void Button_Click_Entrees(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }

        private void Button_Click_Sides(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SideSelection.xaml", UriKind.Relative));
        }

        private void Button_Click_Drinks(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DrinkSelection.xaml", UriKind.Relative));
        }
    }
}
