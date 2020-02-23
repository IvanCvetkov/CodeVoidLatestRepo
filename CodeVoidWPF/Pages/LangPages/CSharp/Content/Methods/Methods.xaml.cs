using System;
using System.Windows;
using System.Windows.Controls;

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Methods
{
    /// <summary>
    /// Interaction logic for Methods.xaml
    /// </summary>
    public partial class Methods : Page
    {
        public Methods()
        {
            InitializeComponent();
        }

        private void Vs_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfoTwo.xaml", UriKind.Relative));
        }
        private void Forward_Click(object sender, RoutedEventArgs e) 
        {
            
        }
        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void BtnCompile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
