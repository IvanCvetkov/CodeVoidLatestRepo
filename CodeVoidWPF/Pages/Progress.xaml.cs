using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Progress.xaml
    /// </summary>
    public partial class Progress : Page
    {
        public Progress()
        {
            InitializeComponent();
        }
        private void BtnBackProgress_Click(object sender, RoutedEventArgs e)
        {
            Await();
        }
        private async void Await()
        {
            await Task.Delay(700);
            MainWindow.win.NavigateLast();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
