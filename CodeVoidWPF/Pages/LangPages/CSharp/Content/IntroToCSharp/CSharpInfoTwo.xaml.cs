using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Threading.Tasks;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.IntroToCSharp
{
    /// <summary>
    /// Interaction logic for CSharpInfoTwo.xaml
    /// </summary>
    public partial class CSharpInfoTwo : Page
    {
        public CSharpInfoTwo()
        {
            InitializeComponent();
        }
        //********************//
        //LayoutRoot Grid cast//
        //********************//
        private async void FirstPIAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));
        }
        private async void ThirdPIAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoThree.xaml", UriKind.Relative));
        }
        private async void TextFilesAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/TextFiles/TextFiles.xaml", UriKind.Relative));
        }
        private async void ExceptionsAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Exceptions/Exceptions.xaml", UriKind.Relative));
        }
        private async void MethodsAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Methods/Methods.xaml", UriKind.Relative));
        }
        private async void ArraysAwait()
        {
            await Task.Delay(700);
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Arrays/Arrays.xaml", UriKind.Relative));
        }
        private void Arrays_Click(object sender, RoutedEventArgs e)
        {
            ArraysAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }
        private void Exceptions_Click(object sender, RoutedEventArgs e)
        {
            ExceptionsAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }
        private void Methods_Click(object sender, RoutedEventArgs e)
        {
            MethodsAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }
        private void TextFiles_Click(object sender, RoutedEventArgs e)
        {
            TextFilesAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }
        private void ThirdPageContent_Click(object sender, RoutedEventArgs e)
        {
            ThirdPIAwait();
            LayoutRoot.Visibility = Visibility.Visible;
            AllRectanglesUnloaded();
        }
        private void FirstPageContent_Click(object sender, RoutedEventArgs e)
        {
            FirstPIAwait();
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
                        ArraysRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        ExceptionsRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        MethodsRec.Fill = new SolidColorBrush(Colors.DarkGray);
                        TextFilesRec.Fill = new SolidColorBrush(Colors.DarkGray);
                    }
                }
            }
        }


        //Animations
        public void AllRectanglesLoaded()
        {
            //animation code
            DoubleAnimation arraysRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation exceptionsRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation methodsRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation textFilesRectangle = new DoubleAnimation()
            {
                From = 0,
                To = 920,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            
            

            //calling the animation code
            
            //reffering to the XAML objects
            ArraysRec.BeginAnimation(WidthProperty, arraysRectangle);
            ExceptionsRec.BeginAnimation(WidthProperty, exceptionsRectangle);
            MethodsRec.BeginAnimation(WidthProperty, methodsRectangle);
            TextFilesRec.BeginAnimation(WidthProperty, textFilesRectangle);
        }
        public void AllRectanglesUnloaded()
        {
            DoubleAnimation arrayRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation exceptionRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation methodRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };
            DoubleAnimation textFilesRectangle = new DoubleAnimation()
            {
                From = 920,
                To = 0,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            ArraysRec.BeginAnimation(WidthProperty, arrayRectangle);
            ExceptionsRec.BeginAnimation(WidthProperty, exceptionRectangle);
            MethodsRec.BeginAnimation(WidthProperty, methodRectangle);
            TextFilesRec.BeginAnimation(WidthProperty, textFilesRectangle);
        }
    }
}
