using System.Windows;
using System.Windows.Controls;
using System;

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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
