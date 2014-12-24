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

namespace SFFGuide.bothSf_fQ
{
    public partial class q1 : PhoneApplicationPage
    {
        public q1()
        {
            InitializeComponent();
        }

        private void future_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(
           new Uri("/bothsF+fQ/future.xaml", UriKind.Relative));
        }

        private void past_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(
           new Uri("/bothsF+fQ/past.xaml", UriKind.Relative));
        }
    }
}