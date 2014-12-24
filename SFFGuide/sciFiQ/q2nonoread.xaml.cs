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
    public partial class q2nonoread : PhoneApplicationPage
    {
        public q2nonoread()
        {
            InitializeComponent();
        }

        private void femisnism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theLeftHandOfDarkness.xaml", UriKind.Relative));
        }

        private void communism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/sciFiBooks/theDispossessed.xaml", UriKind.Relative));
        }
    }
}