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

namespace SFFGuide.bothSf_fQ
{
    public partial class futureno : PhoneApplicationPage
    {
        public futureno()
        {
            InitializeComponent();
        }

       

        private void dyingSun_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/bothSf+fBooks/theBookOfTheNewSun.xaml", UriKind.Relative));
        }

        private void impalingDemon_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/bothSf+fBooks/theHyperionOmnibus.xaml", UriKind.Relative));
        }
    }
}