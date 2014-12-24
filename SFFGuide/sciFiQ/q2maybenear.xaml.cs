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
    public partial class q2maybenear : PhoneApplicationPage
    {
        public q2maybenear()
        {
            InitializeComponent();
        }

        private void vignettes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theMartianChronicles.xaml", UriKind.Relative));
        }

        private void environmentalism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theMarsTrilogy.xaml", UriKind.Relative));
        }

        private void lookingGlass_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theSpaceTrilogy.xaml", UriKind.Relative));
        }
    }
}