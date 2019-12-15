using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CodeVoidWPF.Pages.LangPages.CSharp
{
    /// <summary>
    /// Interaction logic for CSharpInfo.xaml
    /// </summary>
    public partial class CSharpInfo : Page
    {
        public CSharpInfo()
        {
            InitializeComponent();
        }
        //Await Methods
        /*Coded in this way with the await methods bcs
         * there's no other way of doing it and being 
         * able to trigger the loading/unloading 
         * animation from the LayoutRoot Grid*/

        //********************//
        //LayoutRoot Grid cast//
        //********************//
        private async void IntroductionAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharp.xaml", UriKind.Relative));
        }
        private async void VariablesAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Variable/Variables.xaml", UriKind.Relative));
        }
        private async void OperatorsAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Operators/Operators.xaml", UriKind.Relative));
        }
        private async void LoopsAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/Loops.xaml", UriKind.Relative));
        }
        private async void SecondPIAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoTwo.xaml", UriKind.Relative));
        }
        private async void LanguagesAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Pages.Languages());
        }
        //Default Pages
        private void Introduction_Click(object sender, RoutedEventArgs e)
        {
            IntroductionAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void Variables_Click(object sender, RoutedEventArgs e)
        {
            VariablesAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void Operators_Click(object sender, RoutedEventArgs e)
        {
            OperatorsAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void Loops_Click(object sender, RoutedEventArgs e)
        {
            LoopsAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }


        //Second page navigation
        private void SecondPageContent_Click(object sender, RoutedEventArgs e)
        {
            SecondPIAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        //Go back
        private void LanguagesPage_Click(object sender, RoutedEventArgs e)
        {
            LanguagesAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }



        
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Hidden;
            AllRectanglesLoaded();

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
                        IntroductionRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        VariablesRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        OperatorsRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        LoopsRec.Fill = new SolidColorBrush(Colors.DarkGray);
                    }
                }
            }
        }
       //Animations
        //public void AllGrids()
        //{
        //    DoubleAnimation introductionGrid = new DoubleAnimation()
        //    {
        //        From = 0,
        //        To = 600,
        //        Duration = TimeSpan.FromSeconds(1),

        //        EasingFunction = new QuinticEase()
        //    };
        //    DoubleAnimation variablesGrid = new DoubleAnimation()
        //    {
        //        From = 0,
        //        To = 600,
        //        Duration = TimeSpan.FromSeconds(1),

        //        EasingFunction = new QuinticEase()
        //    };
        //    DoubleAnimation operatorsGrid= new DoubleAnimation()
        //    {
        //        From = 0,
        //        To = 600,
        //        Duration = TimeSpan.FromSeconds(1),

        //        EasingFunction = new QuinticEase()
        //    };
        //    DoubleAnimation loopsGrid = new DoubleAnimation()
        //    {
        //        From = 0,
        //        To = 600,
        //        Duration = TimeSpan.FromSeconds(1),

        //        EasingFunction = new QuinticEase()
        //    };

        //    IntroductionGrid.BeginAnimation(WidthProperty, introductionGrid);
        //    VariablesGrid.BeginAnimation(WidthProperty, variablesGrid);
        //    OperatorsGrid.BeginAnimation(WidthProperty, operatorsGrid);
        //    LoopsGrid.BeginAnimation(WidthProperty, loopsGrid);
        //}
        public void AllRectanglesLoaded()
        {
            DoubleAnimation introductionRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation variablesRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation operatorsRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation loopsRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            IntroductionRec.BeginAnimation(WidthProperty, introductionRectangle);
            VariablesRec.BeginAnimation(WidthProperty, variablesRectangle);
            OperatorsRec.BeginAnimation(WidthProperty, operatorsRectangle);
            LoopsRec.BeginAnimation(WidthProperty, loopsRectangle);
        }
        public void AllRectanglesUnloaded()
        {
            DoubleAnimation introductionRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation variablesRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation operatorsRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation loopsRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            IntroductionRec.BeginAnimation(WidthProperty, introductionRectangle);
            VariablesRec.BeginAnimation(WidthProperty, variablesRectangle);
            OperatorsRec.BeginAnimation(WidthProperty, operatorsRectangle);
            LoopsRec.BeginAnimation(WidthProperty, loopsRectangle);
        }
    }
}
