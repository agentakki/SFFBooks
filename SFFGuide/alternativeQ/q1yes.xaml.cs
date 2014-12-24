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
    public partial class q1yes : PhoneApplicationPage
    {
        public q1yes()
        {
            InitializeComponent();
        }

        private void underdog_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/flowersForAlgernon.xaml", UriKind.Relative));
        }

        private void romance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/alternativeQ/q1yesromance.xaml", UriKind.Relative));
        }
    }
}