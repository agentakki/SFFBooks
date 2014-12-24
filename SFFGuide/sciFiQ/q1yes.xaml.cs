using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SFFGuide.sciFiQ
{
    public partial class q1yes : PhoneApplicationPage
    {
        public q1yes()
        {
            InitializeComponent();
        }

        private void neoVictorian_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theDiamondAge.xaml", UriKind.Relative));
        }

        private void grittyNoir_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/neuromancer.xaml", UriKind.Relative));
        }

        private void samurai_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/snowCrash.xaml", UriKind.Relative));
        }
    }
}