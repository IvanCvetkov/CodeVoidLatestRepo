using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows.Media.Animation;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>

    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/MainPages/About/About.xaml", UriKind.Relative));
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Location_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/MainPages/Location/Location.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BlueGridMethod();
            RectangleMethod();
            PurpleGridMethod();
        }
        public void BlueGridMethod()
        {
            DoubleAnimation db = new DoubleAnimation();
            db.From = 0;
            db.To = 1196;
            db.Duration = TimeSpan.FromSeconds(1);

            db.EasingFunction = new QuinticEase();

            BlueGrid.BeginAnimation(WidthProperty, db);
        }
        public void RectangleMethod()
        {
            DoubleAnimation db = new DoubleAnimation();
            db.From = 0;
            db.To = 1196;
            db.Duration = TimeSpan.FromSeconds(1);

            db.EasingFunction = new QuinticEase();

            Rec.BeginAnimation(WidthProperty, db);
        }
        public void PurpleGridMethod()
        {
            DoubleAnimation db = new DoubleAnimation();
            db.From = 0;
            db.To = 1196;
            db.Duration = TimeSpan.FromSeconds(1);

            db.EasingFunction = new QuinticEase();

            PurpleGrid.BeginAnimation(WidthProperty, db);
        }
    }
}