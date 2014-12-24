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
    public partial class q2nono : PhoneApplicationPage
    {
        public q2nono()
        {
            InitializeComponent();
        }

        private void politics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q2nonoread.xaml", UriKind.Relative));
        }

        private void religion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/sciFiQ/q2nonogood.xaml", UriKind.Relative));
        }

        private void philosophy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/doAndroidsDreamOfElectricSheep.xaml", UriKind.Relative));
        }

        private void none_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiQ/q2nononone.xaml", UriKind.Relative));
        }
    }
}