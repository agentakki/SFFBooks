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
    public partial class q2yes : PhoneApplicationPage
    {
        public q2yes()
        {
            InitializeComponent();
        }

        private void dictators_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/alternativeQ/q2yesdictators.xaml", UriKind.Relative));
        }

        private void madness_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/alternativeQ/q2yesmadness.xaml", UriKind.Relative));
        }
    }
}