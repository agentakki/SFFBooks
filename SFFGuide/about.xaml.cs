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
using Microsoft.Phone.Tasks;

namespace SFFGuide
{
    public partial class about : PhoneApplicationPage
    {
        public about()
        {
            InitializeComponent();
        }

        private void moreAppsHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceSearchTask moreAppsMarketplaceSearchTask = new MarketplaceSearchTask();

            moreAppsMarketplaceSearchTask.SearchTerms = "Akshay Bakshi";

            moreAppsMarketplaceSearchTask.Show();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask supportEmailComposeTask = new EmailComposeTask();

            supportEmailComposeTask.Subject = "#SF+FBooks";
            supportEmailComposeTask.To = "akshaybakshi@live.com";
           
            supportEmailComposeTask.Show();
        }

        private void twitterHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
           
                WebBrowserTask webBrowserTask = new WebBrowserTask();

                webBrowserTask.URL = "http://www.twitter.com/AgentAkki";

                webBrowserTask.Show();
        }

        
    }
}