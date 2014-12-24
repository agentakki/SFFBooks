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

namespace SFFGuide.fantasyQ
{
    public partial class q2noyes : PhoneApplicationPage
    {
        public q2noyes()
        {
            InitializeComponent();
        }

        private void modernMythology_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(
            new Uri("/fantasyBooks/americanGods.xaml", UriKind.Relative));
        }

        private void worldBeneathCity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/fantasyBooks/neverwhere.xaml", UriKind.Relative));
        }
    }
}