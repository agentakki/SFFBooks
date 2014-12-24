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
    public partial class q4nono : PhoneApplicationPage
    {
        public q4nono()
        {
            InitializeComponent();
        }

        private void robots_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/iRobot.xaml", UriKind.Relative));
        }

        private void martians_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/sciFiBooks/theIllustratedman.xaml", UriKind.Relative));
        }
    }
}