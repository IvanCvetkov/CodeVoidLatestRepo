using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows.Media.Animation;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Management;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>

    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Buttons
        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutPage();
        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            NewsPage();
        }
        private void Location_Click(object sender, RoutedEventArgs e)
        {
            ContactPage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //On MainPage Load/Start
            BlueGridMethod();
            RectangleMethod();
            PurpleGridMethod();
        }
        //Animation Methods
        public void BlueGridMethod()
        {
            DoubleAnimation db = new DoubleAnimation
            {
                From = 0,
                To = 1196,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            BlueGrid.BeginAnimation(WidthProperty, db);
        }
        public void RectangleMethod()
        {
            DoubleAnimation db = new DoubleAnimation
            {
                From = 0,
                To = 1196,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            Rec.BeginAnimation(WidthProperty, db);
        }
        public void PurpleGridMethod()
        {
            DoubleAnimation db = new DoubleAnimation
            {
                From = 0,
                To = 1196,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            PurpleGrid.BeginAnimation(WidthProperty, db);
        }

        //Linking Methods
        public async void AboutPage()
        {
            await Task.Delay(250);
            this.NavigationService.Navigate(new Uri("Pages/MainPages/About/About.xaml", UriKind.Relative));
        }
        public async void ContactPage()
        {
            await Task.Delay(250);
            this.NavigationService.Navigate(new Uri("Pages/MainPages/Location/Location.xaml", UriKind.Relative));
        }
        public async void NewsPage()
        {
            await Task.Delay(250);
            this.NavigationService.Navigate(new Uri("Pages/News.xaml", UriKind.Relative));
        }

        private void AboutIcon_Click(object sender, RoutedEventArgs e)
        {
            //UninstallProgram("Sourcetree");
        }
        //private bool UninstallProgram(string ProgramName)
        //{
        //    try
        //    {
        //        ManagementObjectSearcher mos = new ManagementObjectSearcher(
        //          "SELECT * FROM Win32_Product WHERE Name = '" + ProgramName + "'");
        //        foreach (ManagementObject mo in mos.Get())
        //        {
        //            try
        //            {
        //                if (mo["Name"].ToString() == ProgramName)
        //                {
        //                    object hr = mo.InvokeMethod("Uninstall", null);
        //                    return (bool)hr;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("nope");
        //            }
        //        }

        //        //was not found...
        //        return false;

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}