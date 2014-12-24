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

namespace SFFGuide.alternativeQ
{
    public partial class q3 : PhoneApplicationPage
    {
        public q3()
        {
            InitializeComponent();
        }

        private void whoNeedsBooks_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/fahrenheit451.xaml", UriKind.Relative));
        }

        private void whoNeedsFreeWill_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/aClockworkOrange.xaml", UriKind.Relative));
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/alternativeQ/q3neither.xaml", UriKind.Relative));
        }
    }
}