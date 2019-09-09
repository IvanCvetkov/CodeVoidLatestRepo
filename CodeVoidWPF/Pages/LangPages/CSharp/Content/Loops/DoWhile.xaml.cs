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

namespace CodeVoidWPF.Pages.LangPages.CSharp.Content.Loops
{
    /// <summary>
    /// Interaction logic for DoWhile.xaml
    /// </summary>
    public partial class DoWhile : Page
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/LoopsTwo.xaml", UriKind.Relative));
        }

        private void DoWhileTwo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/Loops/DoWhileTwo.xaml", UriKind.Relative));
        }
    }
}
