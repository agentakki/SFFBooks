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
    public partial class q2yes : PhoneApplicationPage
    {
        public q2yes()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/sciFiQ/q2yesyes.xaml", UriKind.Relative));
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/sciFiQ/q2yesno.xaml", UriKind.Relative));
        }

        private void mayBe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/sciFiQ/q3.xaml", UriKind.Relative));
        }
    }
}