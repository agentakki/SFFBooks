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

namespace SFFGuide
{
    public partial class watershipDown : PhoneApplicationPage
    {
        public watershipDown()
        {
            InitializeComponent();
        }

        private void startOverButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}
