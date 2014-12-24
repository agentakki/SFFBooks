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
    public partial class q2nonononecomfort : PhoneApplicationPage
    {
        public q2nonononecomfort()
        {
            InitializeComponent();
        }

        private void mystery_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theCavesOfSteel.xaml", UriKind.Relative));
        }

        private void thriller_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/lucifersHammer.xaml", UriKind.Relative));
        }
    }
}