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
    public partial class q2yesyes : PhoneApplicationPage
    {
        public q2yesyes()
        {
            InitializeComponent();
        }

        private void bugs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/starshipTroopers.xaml", UriKind.Relative));
        }

        private void farAwayBugs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/endersGame.xaml", UriKind.Relative));
        }

        private void spiritualColonial_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theDuneChronicles.xaml", UriKind.Relative));
        }

        private void humanHuman_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theMoonIsAHarshMistress.xaml", UriKind.Relative));
        }

        private void everyone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/oldMansWar.xaml", UriKind.Relative));
        }

        private void alien_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theForeverWar.xaml", UriKind.Relative));
        }
    }
}