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
    public partial class q1yesRynCC : PhoneApplicationPage
    {
        public q1yesRynCC()
        {
            InitializeComponent();
        }

        private void classic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/theOutlanderSeries.xaml", UriKind.Relative));
        }

        private void contemporary_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/theTimeTravelersWife.xaml", UriKind.Relative));
        }
    }
}