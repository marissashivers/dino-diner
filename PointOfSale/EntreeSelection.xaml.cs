/*  EntreeSelection.xaml.cs
*   Author: Marissa Shivers
*/
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public void Add_Brontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Items.Add(bw);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        private void Add_Dinonuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Items.Add(dn);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        private void Add_TRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger tkb = new TRexKingBurger();
                order.Items.Add(tkb);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        private void Add_PterodactylWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings ptw = new PterodactylWings();
                order.Items.Add(ptw);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        private void Add_Steakosaurus(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Items.Add(sb);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        private void Add_VelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Items.Add(vw);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        private void Add_PBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Items.Add(pbj);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }
    }
}
