﻿using System;
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
    public partial class q4nomaybe : PhoneApplicationPage
    {
        public q4nomaybe()
        {
            InitializeComponent();
        }

        private void bureaucraticSatire_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/goingPostal.xaml", UriKind.Relative));
        }

        private void religiousSatire_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/smallGods.xaml", UriKind.Relative));
        }

        private void funWithParts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
         new Uri("/fantasyBooks/theXanthSeries.xaml", UriKind.Relative));
        }
    }
}