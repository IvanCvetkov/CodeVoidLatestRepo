using CodeVoidWPF.Pages.LangPages.CSharp.Content.Alerts;
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

        bool dmPrice=false, firstLoginPrice=false, firstVSPrice=false, firstCCPrice = false;
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
            string firstLoginPath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\FirstLogin.txt";
            string firstVSPath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\FirstVS.txt";
            string firstCodeCompilationPath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\FirstCodeCompilation.txt";
            string DarkModePath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\DarkMode.txt";
            
            using (StreamReader sw = new StreamReader(firstLoginPath))
            {

                if (!File.Exists(firstLoginPath))
                    File.Create(firstLoginPath);

                if (File.Exists(firstLoginPath))
                {
                    string line;
                    line = sw.ReadLine();
                    var bc = new BrushConverter();
                    if (line.Contains("FirstLogin:True"))
                    {
                        FirstLogin.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        log.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        firstLoginPrice = true;
                    }
                    else
                        FirstLogin.IsEnabled = false;
                }
            }
            using (StreamReader sw = new StreamReader(firstVSPath))
            {

                if (!File.Exists(firstVSPath))
                    File.Create(firstVSPath);

                if (File.Exists(firstVSPath))
                {
                    string line;
                    line = sw.ReadLine();
                    var bc = new BrushConverter();
                    if (line.Contains("FirstVS:True"))
                    {
                        FirstVS.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        vs.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        firstVSPrice = true;
                    }
                    else
                        FirstVS.IsEnabled = false;
                }
            }
            using (StreamReader sw = new StreamReader(firstCodeCompilationPath))
            {

                if (!File.Exists(firstCodeCompilationPath))
                    File.Create(firstCodeCompilationPath);

                if (File.Exists(firstCodeCompilationPath))
                {
                    string line;
                    line = sw.ReadLine();
                    var bc = new BrushConverter();
                    if (line.Contains("FirstCodeCompilation:True"))
                    {
                        FirstCodeCompilation.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        codecomp.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        firstCCPrice = true;
                    }
                    else
                        FirstCodeCompilation.IsEnabled = false;
                }
            }
            using (StreamReader sw = new StreamReader(DarkModePath))
            {

                if (!File.Exists(DarkModePath))
                    File.Create(DarkModePath);

                if (File.Exists(DarkModePath))
                {
                    string line;
                    line = sw.ReadLine();
                    var bc = new BrushConverter();
                    if (line.Contains("DarkMode:True"))
                    {
                        DarkMode.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        dm.Background = (Brush)bc.ConvertFrom("#FF68BD22");
                        dmPrice = true;
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


        string desktop_Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private void FirstLogin_Click(object sender, RoutedEventArgs e)
        {
             if (firstLoginPrice)
            {
                string pathFirstLogin = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/FirstLogin.txt";
                string loginPath = System.IO.Path.Combine(desktop_Path, pathFirstLogin);
                using (StreamWriter sw = new StreamWriter(loginPath))
                {
                    sw.WriteLine("20");
                }
            }

            
        }
        private void FirstVS_Click(object sender, RoutedEventArgs e)
        {
            if (firstVSPrice)
            {
                string pathFirstVS = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/FirstVS.txt";
                string vsPath = System.IO.Path.Combine(desktop_Path, pathFirstVS);
                using (StreamWriter sw = new StreamWriter(vsPath))
                {
                    sw.WriteLine("20");
                }
            }
        }
        private void FirstCodeCompilation_Click(object sender, RoutedEventArgs e)
        {
           if (firstCCPrice)
            {
                string pathFirstCC = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/FirstCC.txt";
                string firstCCpath = System.IO.Path.Combine(desktop_Path, pathFirstCC);
                using (StreamWriter sw = new StreamWriter(firstCCpath))
                {
                    sw.WriteLine("20");
                }
            }
        }
        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
             if (dmPrice)
            {
                string pathDarkMode = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/DarkMode.txt";
                string dmPath = System.IO.Path.Combine(desktop_Path, pathDarkMode);
                using (StreamWriter sw = new StreamWriter(dmPath))
                {
                    sw.WriteLine("20");
                }
            }

        }
    }
}
