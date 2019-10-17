/*  DrinkSelection.xaml.cs
*   Author: Marissa Shivers
*/
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking on soda will add the "choose flavor" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_Soda(object sender, RoutedEventArgs e)
        {

            specialButton1.Content = "Choose flavor";
            specialButton1.Click += new RoutedEventHandler(Click_Choose_Flavor);

            specialButton2.Content = "";

            specialButton3.Content = "Remove ice";
            specialButton3.Click += new RoutedEventHandler(Click_RemoveIce);
        }

        public void Click_Tea(object sender, RoutedEventArgs e)
        {
            specialButton1.Content = "Add sweetener";
            specialButton1.Click += new RoutedEventHandler(Click_Sweetener);

            specialButton2.Content = "Add lemon";
            specialButton2.Click += new RoutedEventHandler(Click_Lemon);

            specialButton3.Content = "Remove ice";
            specialButton3.Click += new RoutedEventHandler(Click_RemoveIce);
        }

        public void Click_Coffee(object sender, RoutedEventArgs e)
        {
            specialButton1.Content = "Make decaf";
            specialButton1.Click += new RoutedEventHandler(Click_Decaf);

            specialButton2.Content = "Add cream";
            specialButton2.Click += new RoutedEventHandler(Click_Cream);

            specialButton3.Content = "Add ice";
            specialButton3.Click += new RoutedEventHandler(Click_AddIce);
        }

        public void Click_Water(object sender, RoutedEventArgs e)
        {
            specialButton1.Content = "";
            specialButton2.Content = "";
            specialButton3.Content = "Remove ice";
            specialButton3.Click += new RoutedEventHandler(Click_RemoveIce);
        }

        // ****************************************************************

        public void Click_Choose_Flavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FlavorSelection.xaml", UriKind.Relative));
        }

        public void Click_Sweetener(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added sweetener");
        }

        public void Click_Lemon(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added lemon");
        }

        public void Click_Decaf(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jurassic Java is now decaf");
        }

        public void Click_Cream(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added cream to Jurassic Java");
        }

        public void Click_RemoveIce(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Removed ice");
        }

        public void Click_AddIce(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added ice");
        }
    }
}
