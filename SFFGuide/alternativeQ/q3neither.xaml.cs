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
    public partial class q3neither : PhoneApplicationPage
    {
        public q3neither()
        {
            InitializeComponent();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/theStand.xaml", UriKind.Relative));
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/theRoad.xaml", UriKind.Relative));
        }
    }
}