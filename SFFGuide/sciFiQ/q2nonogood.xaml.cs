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
    public partial class q2nonogood : PhoneApplicationPage
    {
        public q2nonogood()
        {
            InitializeComponent();
        }

        private void catholicism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/aCanticleForLeibowitz.xaml", UriKind.Relative));
        }

        private void humanism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/strangerInAStrangeland.xaml", UriKind.Relative));
        }
    }
}