/*  MainWindow.xaml.cs
*   Author: Marissa Shivers
*/
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for main window page
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order; //casting
            if (order != null)
            {
                OrderControl.NavigationService = OrderUI.NavigationService;
            }
        }

        // private helper method, refeshes page?
        private void PassOnDataContext()
        {
            Page page = OrderUI.Content as Page;
            if (page != null)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }
    }
}
