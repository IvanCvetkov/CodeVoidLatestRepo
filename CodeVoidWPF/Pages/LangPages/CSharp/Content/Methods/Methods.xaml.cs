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
using System.Diagnostics;
using System.Windows.Media;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            string path = "CodeVoidProject\\CodeVoid\\CodeVoidWPF\\ExecutablePrograms\\ForLoop\\ForLoop.sln";
            Process.Start(Directory.GetCurrentDirectory() + path);
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));
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
