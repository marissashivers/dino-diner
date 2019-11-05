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
        /// <summary>
        /// Constructor for Entree Seletion page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button for adding Brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Brontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Add(bw);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // navigate to appropriate entree customization page
            NavigationService.Navigate(new Uri("/EntreeCustomize/Brontowurst_Customize.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for adding DinoNuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Dinonuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            
            // navigate to appropriate entree customization page
            NavigationService.Navigate(new Uri("/EntreeCustomize/DinoNuggets_Customize.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for adding TRex King Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_TRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger tkb = new TRexKingBurger();
                order.Add(tkb);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // nagivate
            NavigationService.Navigate(new Uri("EntreeCustomize/TRexKingBurger_Customize.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for adding Pterodactyl Wings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_PterodactylWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings ptw = new PterodactylWings();
                order.Add(ptw);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for adding Steakosaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Steakosaurus(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // navigate to appropriate entree customization page
            NavigationService.Navigate(new Uri("/EntreeCustomize/SteakosaurusBurger_Customize.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for adding Velociwrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_VelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // navigate
            NavigationService.Navigate(new Uri("EntreeCustomize/VelociWrap_Customize.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for adding PBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_PBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // back to main page automatically
            NavigationService.Navigate(new Uri("EntreeCustomize/PrehistoricPBJ_Customize.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Button for back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuCategorySelection.xaml", UriKind.Relative));
        }
    }
}
