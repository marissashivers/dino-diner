/*  SideSelection.xaml.cs
*   Author: Marissa Shivers
*/
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        public void OnAddFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Fryceritops ft = new Fryceritops();
                order.Items.Add(ft);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                // only change size if the item is a size
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        public void OnCurrentChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    // set radio to side.Size property
                    // Disable selection of new side
                    AddFryceritops.IsEnabled = false;
                }
                else
                {
                    AddFryceritops.IsEnabled = true;
                }
            }
            
        }


    }
}
