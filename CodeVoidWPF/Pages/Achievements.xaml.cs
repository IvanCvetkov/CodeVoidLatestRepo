using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeVoidWPF.Pages
{
    //Background="#FFFF1818" red
    //Background="#FF68BD22" green


    /// <summary>
    /// Interaction logic for Achievements.xaml
    /// </summary>
    public partial class Achievements : Page
    {
        public Achievements()
        {
            InitializeComponent();
        }
        
        private async void Await()
        {
            await Task.Delay(1000);
            MainWindow.win.NavigateLast();
        }
        private void BtnBackAchievements_Click(object sender, RoutedEventArgs e)
        {
            Await();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

       

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Hidden;
            AllRectanglesLoaded();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string achievementsPath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\Achievements.txt";

            using (StreamReader sw = new StreamReader(achievementsPath))
            {
                var bc = new BrushConverter();
                if (!File.Exists(achievementsPath))
                    File.Create(achievementsPath);

                if (File.Exists(achievementsPath))
                {
                    string line;
                    line = sw.ReadLine();
                    if (line.Contains("FirstLogin:True"))
                    {
                        FirstLogin.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        log.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                    }
                    else
                        FirstLogin.IsEnabled = false;
                    if (line.Contains("FirstVS:True"))
                    {
                        FirstVS.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        vs.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                    }
                    else
                        FirstVS.IsEnabled = false;
                    if (line.Contains("FirstCodeCompilation:True"))
                    {
                        FirstCodeCompilation.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        codecomp.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                    }
                    else
                        FirstCodeCompilation.IsEnabled = false;
                    if (line.Contains("DarkMode:True"))
                    {
                        DarkMode.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        dm.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                    }
                    else
                        DarkMode.IsEnabled = false;
                }
            }
        }
        //Animations
        public void AllRectanglesLoaded()
        {
            //animation code
            DoubleAnimation firstLoginRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation firstVSRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation firstCodeCompRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation darkModeRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };



            //calling the animation code

            //reffering to the XAML objects
            FirstLoginRec.BeginAnimation(WidthProperty, firstLoginRectangle);
            FirstVSRec.BeginAnimation(WidthProperty, firstVSRectangle);
            FirstCodeCompRec.BeginAnimation(WidthProperty, firstCodeCompRectangle);
            DarkModeRec.BeginAnimation(WidthProperty, darkModeRectangle);
        }
        public void AllRectanglesUnloaded()
        {
            DoubleAnimation firstLoginRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation firstVSRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation firstCodeCompRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation darkModeRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            FirstLoginRec.BeginAnimation(WidthProperty, firstLoginRectangle);
            FirstVSRec.BeginAnimation(WidthProperty, firstVSRectangle);
            FirstCodeCompRec.BeginAnimation(WidthProperty, firstCodeCompRectangle);
            DarkModeRec.BeginAnimation(WidthProperty, darkModeRectangle);
        }
        private void FirstLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void FirstVS_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void FirstCodeCompilation_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
