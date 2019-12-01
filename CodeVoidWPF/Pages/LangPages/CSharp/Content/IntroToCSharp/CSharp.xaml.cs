using System;
using System.Windows.Media.Animation;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;

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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }
        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //Grid
        //    DoubleAnimation alertGridAnim = new DoubleAnimation()
        //    {
        //        From = MinWidth,
        //        To = 1700,
        //        Duration = TimeSpan.FromSeconds(2),

        //        EasingFunction = new QuinticEase()
        //    };

        //    gr.BeginAnimation(WidthProperty, alertGridAnim);
        //}
        //private void Page_Unloaded(object sender, RoutedEventArgs e)
        //{
        //    //Grid
        //    DoubleAnimation alertGridAnim = new DoubleAnimation()
        //    {
        //        From = 1700,
        //        To = MinWidth,
        //        Duration = TimeSpan.FromSeconds(2),

        //        EasingFunction = new QuinticEase()
        //    };

        //    gr.BeginAnimation(WidthProperty, alertGridAnim);
        //}

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //Delay();
            this.NavigationService.Navigate(new Uri("Pages/LangPages/CSharp/Content/IntroToCSharp/CSharpIntro.xaml", UriKind.Relative));
        }
        //private async void Delay()
        //{
        //    await Task.Delay(2000);
        //}
    }
}