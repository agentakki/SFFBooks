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
    public partial class q6yes : PhoneApplicationPage
    {
        public q6yes()
        {
            InitializeComponent();
        }

        private void scifi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/fantasyQ/q6yesyes.xaml", UriKind.Relative));
        }
    }
}