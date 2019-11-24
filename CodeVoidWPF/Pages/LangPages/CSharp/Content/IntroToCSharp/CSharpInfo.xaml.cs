using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using CodeVoidWPF.Pages.LangPages.CSharp.Content.IntroToCSharp;

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

        //Default Pages
        private void Introduction_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharp.xaml", UriKind.Relative));
        }

        private void Variables_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Variable/Variables.xaml", UriKind.Relative));
        }

        private void Operators_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Operators/Operators.xaml", UriKind.Relative));
        }

        private void Loops_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/Loops.xaml", UriKind.Relative));
        }


        //Bonus Pages
        private void NumSystems_Click(object sender, RoutedEventArgs e)
        {
            string message = "First you need to buy the following module from the shop!";
            MessageBox.Show(message, "Invalid Page");
        }

        //Second page navigation
        private void SecondPageContent_Click(object sender, RoutedEventArgs e)
        {
            AllRectanglesUnloaded();
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoTwo.xaml", UriKind.Relative));
        }

        //Go back
        private void LanguagesPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.Languages());
        }


        //Animations
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AllRectanglesLoaded();
            //AllGrids();
        }
        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }
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
