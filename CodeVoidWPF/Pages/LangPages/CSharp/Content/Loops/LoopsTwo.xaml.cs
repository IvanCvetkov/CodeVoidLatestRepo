using System;
using System.Windows;
using System.Windows.Controls;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Loops
{
    /// <summary>
    /// Interaction logic for LoopsTwo.xaml
    /// </summary>
    public partial class LoopsTwo : Page
    {
        public LoopsTwo()
        {
            InitializeComponent();
        }
         //Loops Pages
        private void While_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/While.xaml", UriKind.Relative));
        }
        private void For_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/For.xaml", UriKind.Relative));
        }
        private void Nested_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/NestedLoops.xaml", UriKind.Relative));
        }
        private void DoWhile_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/DoWhile.xaml", UriKind.Relative));
        }
       
        //Previous Page
        private void BackToExercises_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/Loops.xaml", UriKind.Relative));
        }

        //Next Page
        private void LoopsThree_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));
        }
    }
}
