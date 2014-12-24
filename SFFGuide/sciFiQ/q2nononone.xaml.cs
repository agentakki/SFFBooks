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
    public partial class q2nononone : PhoneApplicationPage
    {
        public q2nononone()
        {
            InitializeComponent();
        }

        private void modern_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/doomsdayBook.xaml", UriKind.Relative));
        }

        private void classic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theTimeMachine.xaml", UriKind.Relative));
        }

        private void comfort_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiQ/q2nonononecomfort.xaml", UriKind.Relative));
        }
    }
}