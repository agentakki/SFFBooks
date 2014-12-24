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
    public partial class q2maybe : PhoneApplicationPage
    {
        public q2maybe()
        {
            InitializeComponent();
        }

        private void near_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/sciFiQ/q2maybenear.xaml", UriKind.Relative));
        }

        private void far_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/2001ASpaceOdyssey.xaml", UriKind.Relative));
        }
    }
}