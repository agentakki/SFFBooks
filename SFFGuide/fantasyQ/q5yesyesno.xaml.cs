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
    public partial class q5yesyesno : PhoneApplicationPage
    {
        public q5yesyesno()
        {
            InitializeComponent();
        }

        private void wizards_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/fantasyBooks/theElricSaga.xaml", UriKind.Relative));
        }

        private void barbarians_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/fantasyBooks/conanTheBarbarianSeries.xaml", UriKind.Relative));
        }
    }
}