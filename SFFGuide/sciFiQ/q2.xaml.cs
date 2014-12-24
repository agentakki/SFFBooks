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
    public partial class q2 : PhoneApplicationPage
    {
        public q2()
        {
            InitializeComponent();
        }

        private void mayBe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q2maybe.xaml", UriKind.Relative));
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q2yes.xaml", UriKind.Relative));
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q2no.xaml", UriKind.Relative));
        }
    }
}