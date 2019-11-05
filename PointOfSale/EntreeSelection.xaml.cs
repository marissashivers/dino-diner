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
        private Entree _entree;

        /// <summary>
        /// Constructor for Entree Seletion page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            _entree = entree;
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
                _entree = bw;
                order.Add(_entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

            // navigate to appropriate entree customization page
            NavigationService.Navigate(new Brontowurst_Customize(_entree as Brontowurst));
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
                _entree = dn;
                order.Add(_entree);
            }
            
            // navigate to appropriate entree customization page
            NavigationService.Navigate(new DinoNuggets_Customize(_entree as DinoNuggets));
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
                _entree = tkb;
                order.Add(_entree);
            }

            // nagivate
            NavigationService.Navigate(new TRexKingBurger_Customize(_entree as TRexKingBurger));
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
                _entree = sb;
                order.Add(_entree);
            }

            // navigate to appropriate entree customization page
            NavigationService.Navigate(new SteakosaurusBurger_Customize(_entree as SteakosaurusBurger));
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
                _entree = vw;
                order.Add(_entree);
            }

            // navigate
            NavigationService.Navigate(new VelociWrap_Customize(_entree as VelociWrap));
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
                _entree = pbj;
                order.Add(_entree);
            }

            // back to main page automatically
            NavigationService.Navigate(new PrehistoricPBJ_Customize(_entree as PrehistoricPBJ));
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
