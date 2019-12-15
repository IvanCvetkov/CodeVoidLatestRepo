using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.IntroToCSharp
{
    /// <summary>
    /// Interaction logic for CSharpInfoThree.xaml
    /// </summary>
    public partial class CSharpInfoThree : Page
    {
        public CSharpInfoThree()
        {
            InitializeComponent();
        }
        private async void FrontAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoFor.xaml", UriKind.Relative));
        }
        private async void BackAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoTwo.xaml", UriKind.Relative));
        }
        private async void StructsAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Structs/StructsStart.xaml", UriKind.Relative));
        }
        private async void TuplesAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Tuples/TuplesStart.xaml", UriKind.Relative));
        }
        private async void LambdaExpressionsAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/LambdaExpressions/LambdaExpressionsStart.xaml", UriKind.Relative));
        }
        private async void PropertiesAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Properties/PropertiesStart.xaml", UriKind.Relative));
        }
        private void Structs_Click(object sender, RoutedEventArgs e)
        {
            StructsAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void Tuples_Click(object sender, RoutedEventArgs e)
        {
            TuplesAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void LambdaExpressions_Click(object sender, RoutedEventArgs e)
        {
            LambdaExpressionsAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void Properties_Click(object sender, RoutedEventArgs e)
        {
            PropertiesAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();

        }

        private void Front_Click(object sender, RoutedEventArgs e)
        {
            FrontAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            BackAwait();
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
                        StructsRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        TuplesRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        LambdaRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        PropertiesRec.Fill = new SolidColorBrush(Colors.DarkGray);
                    }
                }
            }
        }


        //Animations
        public void AllRectanglesLoaded()
        {
            //animation code
            DoubleAnimation structsRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation tupleRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation lambdaRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation propertiesRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };



            //calling the animation code

            //reffering to the XAML objects
            StructsRec.BeginAnimation(WidthProperty, structsRectangle);
            TuplesRec.BeginAnimation(WidthProperty, tupleRectangle);
            LambdaRec.BeginAnimation(WidthProperty, lambdaRectangle);
            PropertiesRec.BeginAnimation(WidthProperty, propertiesRectangle);
        }
        public void AllRectanglesUnloaded()
        {
            DoubleAnimation structsRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation tupleRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation lambdaRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation propertiesRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            StructsRec.BeginAnimation(WidthProperty, structsRectangle);
            TuplesRec.BeginAnimation(WidthProperty, tupleRectangle);
            LambdaRec.BeginAnimation(WidthProperty, lambdaRectangle);
            PropertiesRec.BeginAnimation(WidthProperty, propertiesRectangle);
        }

    }
}
