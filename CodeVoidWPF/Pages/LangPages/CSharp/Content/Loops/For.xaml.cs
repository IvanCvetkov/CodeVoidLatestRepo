using System;
using System.Windows;
using System.Windows.Controls;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Loops
{
    /// <summary>
    /// Interaction logic for For.xaml
    /// </summary>
    public partial class For : Page
    {
        public For()
        {
            InitializeComponent();
        }

        private void BackToExercises_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/LoopsTwo.xaml", UriKind.Relative));
        }

        private void ForTwo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/ForTwo.xaml", UriKind.Relative));
        }
    }
}
