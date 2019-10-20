using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeVoidWPF.Pages.MainPages.Location
{
    /// <summary>
    /// Interaction logic for Location.xaml
    /// </summary>
    public partial class Location : Page
    {
        public Location()
        {
            InitializeComponent();
        }
        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void School_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void District_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            CheckMethod();
            HomeMethod();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            email_send();
        }

        //page methods
        public void CheckMethod()
        {
            //Sets all toolbox items on the page to an inactive state.
            if (Submit.IsEnabled == true)
                Submit.IsEnabled = false;

            if (FirstName.IsEnabled == true)
                FirstName.IsEnabled = false;

            if (LastName.IsEnabled == true)
                LastName.IsEnabled = false;

            if (School.IsEnabled == true)
                School.IsEnabled = false;

            if (District.IsEnabled == true)
                District.IsEnabled = false;

            if (Email.IsEnabled == true)
                Email.IsEnabled = false;

            if (Phone.IsEnabled == true)
                Phone.IsEnabled = false;
        }
        public async void HomeMethod()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
        }
        public void email_send()
        {
            if (MainPage.IsEnabled == true)
                MainPage.IsEnabled = false;

            if (FirstName.IsEnabled == true)
                FirstName.IsEnabled = false;

            if (LastName.IsEnabled == true)
                LastName.IsEnabled = false;

            if (School.IsEnabled == true)
                School.IsEnabled = false;

            if (District.IsEnabled == true)
                District.IsEnabled = false;

            if (Email.IsEnabled == true)
                Email.IsEnabled = false;

            if (Phone.IsEnabled == true)
                Phone.IsEnabled = false;
            //string Eval = new TextRange(.Document.ContentStart, rtbsolution.Document.ContentEnd).Text;

            //string MailTo = "ivan-dd@mail.bg";
            //string MailFrom = "dsoplayerbg@mail.bg";
            //string Subject = Phone.Text;
            //string Password = District.Text;

            //// Send message using html format in Mail
            //string MessageTosend = @"< html >< body > QUERY " + "< br /></ br />< br /></ br />"
            //+ "SOLUTION: "
            //+ "< br /></ br />< br /></ br />"
            //+ "Regards, < br /></ br />"
            //+ "Team </ body ></ html >";

            //SmtpClient smtpmail = new SmtpClient();
            //smtpmail.Host = "smtp.gmail.com";
            //smtpmail.Port = 587;
            //smtpmail.EnableSsl = true;
            //smtpmail.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpmail.UseDefaultCredentials = false;
            //smtpmail.Credentials = new NetworkCredential(MailFrom, Password);
            //MailMessage message = new MailMessage(MailFrom, MailTo, Subject, MessageTosend);
            //message.IsBodyHtml = true;
            //smtpmail.Send(message);
            //MessageBox.Show("Email Sent");
        }
    }
}
