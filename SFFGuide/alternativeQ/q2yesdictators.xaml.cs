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
    public partial class q2yesdictators : PhoneApplicationPage
    {
        public q2yesdictators()
        {
            InitializeComponent();
        }

        private void religiousTotalitarians_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/theHandmaidsTale.xaml", UriKind.Relative));
        }

        private void warlords_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/alternativeBooks/1984.xaml", UriKind.Relative));
        }
    }
}