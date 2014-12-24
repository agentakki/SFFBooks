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
    public partial class q4yes : PhoneApplicationPage
    {
        public q4yes()
        {
            InitializeComponent();
        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theFoundationTrilogy.xaml", UriKind.Relative));
        }

        private void engineering_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/ringworld.xaml", UriKind.Relative));
        }

        private void informationTechnology_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/aFireUponTheDeep.xaml", UriKind.Relative));
        }
    }
}