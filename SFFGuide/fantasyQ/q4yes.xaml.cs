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
    public partial class q4yes : PhoneApplicationPage
    {
        public q4yes()
        {
            InitializeComponent();
        }

        private void romance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/theKushielsLegacySeries.xaml", UriKind.Relative));
        }

        private void magicians_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/jonathanStrangeMrNorrell.xaml", UriKind.Relative));
        }
    }
}