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

namespace SFFGuide.sciFiQue
{
    public partial class q1 : PhoneApplicationPage
    {
        public q1()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q1yes.xaml", UriKind.Relative));
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q2.xaml", UriKind.Relative));
        }

        private void mayBe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/cryptonomicon.xaml", UriKind.Relative));
        }
    }
}