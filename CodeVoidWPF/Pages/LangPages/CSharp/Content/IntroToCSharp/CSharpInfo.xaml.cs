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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void Methods_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Methods/Methods.xaml", UriKind.Relative));
        }

        private void Arrays_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Arrays/Arrays.xaml", UriKind.Relative));
        }

        private void ExceptionHandling_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Exceptions/Exceptions.xaml", UriKind.Relative));
        }

        private void Classes_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Classes/Classes.xaml", UriKind.Relative));
        }

        private void TextFiles_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/TextFiles/TextFiles.xaml", UriKind.Relative));
        }

        private void Introduction_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharp.xaml", UriKind.Relative));
        }
        //Bonus Pages
        private void NumSystems_Click(object sender, RoutedEventArgs e)
        {
            string message = "First you need to buy the following module from the shop!";
            MessageBox.Show(message, "Invalid Page");
        }
    }
}
