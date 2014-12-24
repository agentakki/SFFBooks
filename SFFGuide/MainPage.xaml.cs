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

namespace SFFGuide
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void scifi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/sciFiQ/q1.xaml", UriKind.Relative));

        }

        private void fantasy1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/fantasyQ/q1.xaml", UriKind.Relative));
            
        }

        private void horror1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/horrorQ/q1.xaml", UriKind.Relative));
        }

        private void both1_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(
           new Uri("/bothSf+fQ/q1.xaml", UriKind.Relative));
        }

        private void pictures1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
          new Uri("/pictureQ/q1.xaml", UriKind.Relative));
        }

        private void avoid1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
           new Uri("/alternativeQ/q1.xaml", UriKind.Relative));
        }

        private void loaded_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
        
    }
}