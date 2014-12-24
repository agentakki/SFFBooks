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
    public partial class q4nono : PhoneApplicationPage
    {
        public q4nono()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/thePrincessBride.xaml", UriKind.Relative));
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/stardust.xaml", UriKind.Relative));
        }
    }
}