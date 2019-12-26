using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

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

        //Animations control method
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Hidden;
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

        private void Subject_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            CheckMethod();
            HomeMethod();

            LayoutRoot.Visibility = Visibility.Visible;
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string RTBtext = new TextRange(MessageRTB.Document.ContentStart, MessageRTB.Document.ContentEnd).Text;

            //Email sent successfully alert
            if (FirstName.Text != "*First Name"
                && LastName.Text != "*Last Name"
                && Subject.Text != "*Subject"
                && MessageRTB != null
                && FirstName.Text != ""
                && LastName.Text != ""
                && Subject.Text != ""
                && RTBtext.Length >= 50)
            {
                Email_send();
                MailAlert mailAlert = new MailAlert();
                mailAlert.ShowDialog();
            }


            //Email send failed alert
            if (FirstName.Text == "*First Name"
                || LastName.Text == "*Last Name"
                || Subject.Text == "*Subject"
                || MessageRTB == null
                || FirstName.Text == ""
                || LastName.Text == ""
                || Subject.Text == ""
                || RTBtext.Length < 50)
            {
                FailAlert failAlert = new FailAlert();
                failAlert.ShowDialog();
            }
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

            if (Subject.IsEnabled == true)
                Subject.IsEnabled = false;

            if (Phone.IsEnabled == true)
                Phone.IsEnabled = false;
        }
        public async void HomeMethod()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
        }
        public void Email_send()
        {
            //Initializing the information necessary
            string subject = "\t\t|" + Subject.Text + "|";
            string RTBtext = new TextRange(MessageRTB.Document.ContentStart, MessageRTB.Document.ContentEnd).Text;
            string UserInformation = FirstName.Text + " " + LastName.Text + "\n" +
                                     Phone.Text + "\n" +
                                     School.Text + "\n" +
                                     City.Text;
            string CodeVoidCopyRight = "CopyRight© CodeVoid";
            string message = subject + "\n" +
                             RTBtext + "\n" +
                             UserInformation + "\n" +
                             CodeVoidCopyRight;
           string[] Credentials = new string[3]{ "codevoiddummy@gmail.com",
                "codevoidauthentication", "codevoidreceiver@gmail.com" };

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(Credentials[0], Credentials[1]),
                EnableSsl = true
            };

            //sending the E-mail to the receiver from the dummy
            client.Send(Credentials[0], Credentials[2], subject, message);
        }

        //Information Boxes CleanUp
        private void Message_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
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
        private void Subject_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Subject.Text == "*Subject")
            {
                Subject.Clear();
            }
        }
        private void Phone_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Phone.Text == "Phone")
            {
                Phone.Clear();
            }
        }
        private void School_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (School.Text == "School")
            {
                School.Clear();
            }
        }
        private void City_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (City.Text == "City")
            {
                City.Clear();
            }
        }


    }
}
