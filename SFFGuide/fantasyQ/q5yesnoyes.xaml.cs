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
    public partial class q5yesnoyes : PhoneApplicationPage
    {
        public q5yesnoyes()
        {
            InitializeComponent();
        }

        private void thieves_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/fantasyBooks/mistborn.xaml", UriKind.Relative));
        }

        private void macguffins_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/fantasyBooks/theSwordOfShannaraTrilogy.xaml", UriKind.Relative));
        }

        private void assassins_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/fantasyBooks/theFarseerTrilogy.xaml", UriKind.Relative));
        }

        private void magicians_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/fantasyBooks/theRiftwarSaga.xaml", UriKind.Relative));
        }
    }
}