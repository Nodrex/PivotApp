using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PivotApp2
{
    public partial class SecondPivotPage : PhoneApplicationPage
    {
        public SecondPivotPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string text = NavigationContext.QueryString["text"];
            base.OnNavigatedTo(e);
            //MessageBox.Show(text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //send mail
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "message subject";
            emailComposeTask.Body = "message body";
            emailComposeTask.To = "nchumbadze@gmail.com";
            emailComposeTask.Cc = "cc@example.com";
            emailComposeTask.Bcc = "bcc@example.com";
            emailComposeTask.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //sens sms
            SmsComposeTask smsComposeTask = new SmsComposeTask();
            smsComposeTask.To = "123456789";
            smsComposeTask.Body = "message text";
            smsComposeTask.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("edit menu click");
        }

        private void list_Click(object sender, EventArgs e)
        {
            MessageBox.Show("list menu click");
        }
    }
}