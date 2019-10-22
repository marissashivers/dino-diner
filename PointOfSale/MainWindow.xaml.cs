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
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order; //casting
            if (order != null)
            {
                // do whatever with order
                order.Items.Add(new DinoNuggets());
                order.Items.Add(new Sodasaurus());
                Triceritots tots = new Triceritots();
                //tots.Size = DinoDiner.Menu.Size.Large;
                order.Items.Add(tots);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldBun();
                sb.HoldMustard();
                order.Items.Add(sb);
            }
        }

        // private helper method
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
