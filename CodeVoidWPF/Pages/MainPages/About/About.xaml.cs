using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Threading;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeVoidWPF.Pages.MainPages.About
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
        }
        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            if (Donate.IsEnabled == true)
                Donate.IsEnabled = false;
            if (Contact.IsEnabled == true)
                Contact.IsEnabled = false;
            HomeMethod();
            
        }
        private void Donate_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.IsEnabled == true)
                MainPage.IsEnabled = false;
            if (Contact.IsEnabled == true)
                Contact.IsEnabled = false;
            DonateMethod();

        }
        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.IsEnabled == true)
                MainPage.IsEnabled = false;
            if (Donate.IsEnabled == true)
                Donate.IsEnabled = false;
            ContactMethod();
        }


        //Two seconds of delay before redirecting to a different page.
        public async void DonateMethod()
        {
            await Task.Delay(2000);
            this.NavigationService.Navigate(new Uri("Pages/Donate.xaml", UriKind.Relative));
        }
        public async void ContactMethod()
        {
            await Task.Delay(2000);
            this.NavigationService.Navigate(new Uri("Pages/MainPages/Location/Location.xaml", UriKind.Relative));
        }
        public async void HomeMethod()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative));
        }
    }
}
