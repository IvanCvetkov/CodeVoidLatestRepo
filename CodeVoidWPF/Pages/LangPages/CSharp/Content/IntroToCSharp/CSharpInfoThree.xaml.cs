using System;
using System.Windows;
using System.Windows.Controls;
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
            
        private void Structs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tuples_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LambdaExpressions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Properties_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AllRectanglesLoaded();
        }
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

        private void Front_Click(object sender, RoutedEventArgs e)
        {
                this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoFor.xaml", UriKind.Relative));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoTwo.xaml", UriKind.Relative));
        }
    }
}
