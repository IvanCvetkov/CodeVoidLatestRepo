using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string settingsPath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\DarkModeFix.txt";
            using (StreamReader sw = new StreamReader(settingsPath))
            {
                if (!File.Exists(settingsPath))
                    File.Create(settingsPath);

                if (File.Exists(settingsPath))
                {
                    string line;
                    line = sw.ReadLine();
                    if (line.Contains("DarkMode:True"))
                    {
                        LangGrid.Background = new SolidColorBrush(Color.FromArgb(75, 75, 75, 75));
                    }
                    else
                    {
                        LangGrid.Background = new SolidColorBrush(Color.FromArgb(200, 200, 200, 200));
                    }
                }
            }
        }

        private void BtnPython_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnJava_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnJavascript_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
