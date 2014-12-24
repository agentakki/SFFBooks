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
    public partial class q2yesno : PhoneApplicationPage
    {
        public q2yesno()
        {
            InitializeComponent();
        }

        private void hostile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theWarOfTheWorlds.xaml", UriKind.Relative));
        }

        private void absent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/rendezvousWithRama.xaml", UriKind.Relative));
        }

        private void peaceful_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/childhoodsEnd.xaml", UriKind.Relative));
        }

        private void fatherly_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/contact.xaml", UriKind.Relative));
        }

        private void breeders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theMoteInGodsEye.xaml", UriKind.Relative));
        }
    }
}