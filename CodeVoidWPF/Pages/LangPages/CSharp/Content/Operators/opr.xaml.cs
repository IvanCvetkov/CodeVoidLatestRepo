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
    /// Interaction logic for opr.xaml
    /// </summary>
    public partial class opr : Page
    {
        public opr()
        {
            InitializeComponent();
        }

        private void BackToExercises_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Operators/Operators.xaml", UriKind.Relative));
        }

        private void Operators_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Operators/LogicalOperators.xaml", UriKind.Relative));
        }
    }
}
