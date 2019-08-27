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

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Operators
{
    /// <summary>
    /// Interaction logic for Operators.xaml
    /// </summary>
    public partial class Operators : Page
    {
        public Operators()
        {
            InitializeComponent();
        }

        private void Operators_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Operators/opr.xaml", UriKind.Relative));
        }

        private void BackToExercises_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpInfo.xaml", UriKind.Relative));
        }

    }
}
