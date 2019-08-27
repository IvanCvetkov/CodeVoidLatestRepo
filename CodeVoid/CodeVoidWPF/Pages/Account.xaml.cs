using System.Windows;
using System.Windows.Controls;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        public Account()
        {
            InitializeComponent();
        }

        private void BtnBackAccount_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }
    }
}
