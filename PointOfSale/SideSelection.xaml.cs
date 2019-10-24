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

        public SideSelection()
        {
            InitializeComponent();
        }

        public void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        public void Add_Fryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Fryceritops ft = new Fryceritops();
                order.Items.Add(ft);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void Add_MacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                order.Items.Add(mmc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void Add_MozzSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                MezzorellaSticks ms = new MezzorellaSticks();
                order.Items.Add(ms);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void Add_Tots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Triceritots tots = new Triceritots();
                order.Items.Add(tots);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void MakeSmall(object sender, RoutedEventArgs e)
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

        public void MakeMedium(object sender, RoutedEventArgs e)
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

        public void MakeLarge(object sender, RoutedEventArgs args)
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


        public void OnCurrentChanged(object sender, DependencyPropertyChangedEventArgs args)
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


    }
}
