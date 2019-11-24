using System;
using System.Windows.Media.Animation;
using System.Windows;
using System.Windows.Controls;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for CSharp.xaml
    /// </summary>
    public partial class CSharp : Page
    {
        public CSharp()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpIntro.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}

