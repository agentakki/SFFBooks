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
    public partial class q3noyes : PhoneApplicationPage
    {
        public q3noyes()
        {
            InitializeComponent();
        }

        private void unicorn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/theLastUnicorn.xaml", UriKind.Relative));
        }

        private void bunny_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/watershipDown.xaml", UriKind.Relative));
        }

        private void dragon_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/dragonflight.xaml", UriKind.Relative));
        }
    }
}