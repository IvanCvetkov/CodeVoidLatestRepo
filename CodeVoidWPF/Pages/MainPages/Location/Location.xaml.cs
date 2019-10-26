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
using System.Windows.Controls.Primitives;
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

        private void City_TextChanged(object sender, TextChangedEventArgs e)
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

            if (City.IsEnabled == true)
                City.IsEnabled = false;

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

            if (City.IsEnabled == true)
                City.IsEnabled = false;

            if (Email.IsEnabled == true)
                Email.IsEnabled = false;

            if (Phone.IsEnabled == true)
                Phone.IsEnabled = false;
            string MessageTxT = new TextRange(MessageRTB.Document.ContentStart, MessageRTB.Document.ContentEnd).Text;

            string MailTo = "ivan-dd@mail.bg";
            string MailFrom = Email.Text;
            string FirstNameMessage = FirstName.Text;
            string LastNameMessage = LastName.Text;

            string FullNameMessage = FirstNameMessage + LastNameMessage;

            // Send message using html format in Mail
            string MessageToSend = @"< html >< body > QUERY " + MessageTxT + "< br /></ br />< br /></ br />"
            + "SOLUTION: "
            + "< br /></ br />< br /></ br />"
            + "Regards, < br /></ br />"
            + "Team </ body ></ html >";
            try
            {
                SmtpClient smtpmail = new SmtpClient();
                smtpmail.Host = "smtp.gmail.com";
                smtpmail.Port = 587;
                smtpmail.EnableSsl = true;
                smtpmail.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpmail.UseDefaultCredentials = false;
                smtpmail.Credentials = new NetworkCredential(MailFrom, Phone.Text);
                MailMessage message = new MailMessage(MailFrom, MailTo, FullNameMessage, MessageToSend);
                message.IsBodyHtml = true;
                smtpmail.Send(message);
                MessageBox.Show("Email Sent");
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException || exception is InvalidOperationException || exception is SmtpException
                   ||exception is ObjectDisposedException || exception is SmtpFailedRecipientsException)
                {
                    MessageBox.Show("Mail send failed!");
                }
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //Information Boxes CleanUp
        private void Message_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string Message = new TextRange(MessageRTB.Document.ContentStart, MessageRTB.Document.ContentEnd).Text;
            if (Message == "*Your Message")
            {
                MessageRTB = null;
            }
        }
        private void FirstName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (FirstName.Text == "*First Name")
            {
                FirstName.Clear();
            }
        }
        private void LastName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (LastName.Text == "*Last Name")
            {
                LastName.Clear();
            }
        }
        private void School_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (School.Text == "*School")
            {
                School.Clear();
            }
        }
        private void City_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (City.Text == "*City")
            {
                City.Clear();
            }
        }
        private void Email_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Email.Text == "*Email")
            {
                Email.Clear();
            }
        }
        private void Phone_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Phone.Text == "*Phone")
            {
                Phone.Clear();
            }
        }

        //Information Boxes Redefinition
        private void FirstName_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (FirstName.Text == null)
            {
                FirstName.Text = "*First Name";
            }
        }
    }
}
