using System;
using System.Collections.Generic;
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

        private void TextFiles_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/TextFiles/TextFiles.xaml", UriKind.Relative));
        }

        private void Exceptions_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Exceptions/Exceptions.xaml", UriKind.Relative));
        }

        private void Methods_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Methods/Methods.xaml", UriKind.Relative));
        }

        private void ThirdPageContent_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoThree.xaml", UriKind.Relative));
        }

        private void FirstPageContent_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));
        }

        private void Arrays_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Arrays/Arrays.xaml", UriKind.Relative));
        }


        //Animations
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AllRectanglesLoaded();
        }

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
    }
}
