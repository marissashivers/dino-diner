/*  DinoNuggets_Customize.xaml
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class DinoNuggets_Customize : Page
    {
        private DinoNuggets _dinoNuggets;
        /// <summary>
        /// Constructor for Flavor Selection page
        /// </summary>
        public DinoNuggets_Customize()
        {
            InitializeComponent();
        }

        public DinoNuggets_Customize(DinoNuggets nuggets)
        {
            _dinoNuggets = nuggets;
            InitializeComponent();
        }

        private void Click_AddNugget(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Button_AddNugget))
            {
                if (DataContext is Order order)
                {
                    _dinoNuggets.AddNugget();
                }
            }
        }

        private void Click_BackToMainMenu(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
            {
                MessageBox.Show("NO entries in back navigation history.");
            }
            //NavigationService.Navigate(new Uri("/EntreeSelection.xaml", UriKind.Relative));
        }
    }
}
