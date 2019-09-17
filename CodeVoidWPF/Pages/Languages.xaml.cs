using System;
using System.Windows;
using System.Windows.Controls;

namespace CodeVoidWPF.Pages
{
    public enum CVSceneLanguages
    {
        CSharp = 0
    }

    public partial class Languages : Page
    {
        public Languages()
        {
            InitializeComponent();
        }

        private void BtnBackLanguages_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }

        private void BtnCSharp_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));

            //new app/page instance 
            /*NavigationWindow navWIN = new NavigationWindow();
            navWIN.Content = new CSharp();
            navWIN.Show();*/
        }
    }
}
