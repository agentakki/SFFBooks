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
    public partial class q2noyes : PhoneApplicationPage
    {
        public q2noyes()
        {
            InitializeComponent();
        }

        private void underground_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/journeyToTheCenterOfTheEarth.xaml", UriKind.Relative));
        }

        private void Underwater_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/20000LeaguesUnderTheSea.xaml", UriKind.Relative));
        }
    }
}