using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Diagnostics;

namespace CodeVoidWPF
{

    //Scene Manager
    public enum CVScene
    {
        NULL = -1, Home = 0, Compiler = 1,
        LB = 2, Achievements = 3, Account = 4, Shop = 5, News = 6, Languages = 7, Progress = 9,
        Donate = 10, Website = 12, Settings = 11, Kids = 13
    }

    public partial class MainWindow : Window
    {
        public static CVScene CurrentScene;
        public static CVScene LastScene;

        public static MainWindow win;

        public MainWindow()
        {
            InitializeComponent();
            win = this;
            new SettingsSaver();

            _mainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            _mainFrame.NavigationService.Navigate(new Pages.MainPage());
            CurrentScene = CVScene.Home;
            LastScene = CVScene.NULL;
            ButtonControl();
        }

        //Buttons Bar Color Settings
        public void SetBar(bool isDark)
        {
            if (isDark)
                Bar.Background = new SolidColorBrush(Color.FromRgb(18, 18, 18));
            else
                Bar.Background = new SolidColorBrush(Color.FromRgb(205, 205, 205));
        }

        /// <summary>
        /// Navigates to the last active page.
        /// </summary>
        public void NavigateLast()
        {
            bool fl = false;
            switch (LastScene)
            {
                //Pages Navigation
                case CVScene.Home:
                    _mainFrame.NavigationService.Navigate(new Pages.MainPage());
                    break;
                case CVScene.LB:
                    _mainFrame.NavigationService.Navigate(new Pages.Leaderboards());
                    break;
                case CVScene.Achievements:
                    _mainFrame.NavigationService.Navigate(new Pages.Achievements());
                    break;
                case CVScene.Account:
                    _mainFrame.NavigationService.Navigate(new Pages.Account());
                    break;
                case CVScene.Shop:
                    _mainFrame.NavigationService.Navigate(new Pages.Shop());
                    break;
                case CVScene.News:
                    _mainFrame.NavigationService.Navigate(new Pages.News());
                    break;
                case CVScene.Languages:
                    _mainFrame.NavigationService.Navigate(new Pages.Languages());
                    break;
                case CVScene.Progress:
                    _mainFrame.NavigationService.Navigate(new Pages.Progress());
                    break;
                case CVScene.Donate:
                    _mainFrame.NavigationService.Navigate(new Pages.Donate());
                    break;
                case CVScene.Kids:
                    _mainFrame.NavigationService.Navigate(new Pages.Kids());
                    break;
                case CVScene.Compiler:
                    _mainFrame.NavigationService.Navigate(new Pages.Compiler());
                    break;

                //Settings
                case CVScene.Settings:
                    _mainFrame.NavigationService.Navigate(new Pages.Settings());
                    break;
                default:
                    fl = true;
                    return;
            }
            if (fl)
                return;

            //Flip the scenes
            CurrentScene = LastScene;

            //Toggle the buttons
            ButtonControl();
        }
         
        

        #region BAR

        /// <summary>
        /// Sets the enable value of the buttons.
        /// </summary>
        void ButtonControl()
        {
            //BtnCources.IsEnabled = true;
            BtnHome.IsEnabled = true;
            BtnAchievements.IsEnabled = true;
            BtnLB.IsEnabled = true;
            BtnAccount.IsEnabled = true;
            BtnShop.IsEnabled = true;
            BtnNews.IsEnabled = true;
            BtnLanguages.IsEnabled = true;
            BtnProgress.IsEnabled = true;
            BtnDonate.IsEnabled = true;
            BtnWebsite.IsEnabled = true;
            BtnKids.IsEnabled = true;
            BtnCompiler.IsEnabled = true;
            BtnSett.IsEnabled = true;

            switch (CurrentScene)
            {
                case CVScene.Home:
                    BtnHome.IsEnabled = false;
                    break;
                case CVScene.LB:
                    BtnLB.IsEnabled = false;
                    break;
                case CVScene.Achievements:
                    BtnAchievements.IsEnabled = false;
                    break;
                case CVScene.Account:
                    BtnAccount.IsEnabled = false;
                    break;
                case CVScene.Shop:
                    BtnShop.IsEnabled = false;
                    break;
                case CVScene.News:
                    BtnNews.IsEnabled = false;
                    break;
                case CVScene.Languages:
                    BtnLanguages.IsEnabled = false;
                    break;
                case CVScene.Progress:
                    BtnProgress.IsEnabled = false;
                    break;
                case CVScene.Donate:
                    BtnDonate.IsEnabled = false;
                    break;
                case CVScene.Website:
                    BtnWebsite.IsEnabled = false;
                    break;
                case CVScene.Kids:
                    BtnKids.IsEnabled = false;
                    break;
                case CVScene.Compiler:
                    BtnCompiler.IsEnabled = false;
                    break;

                    //Settings
                case CVScene.Settings:
                    BtnSett.IsEnabled = false;
                    break;
            }


        } 
        //private void BtnCources_Click(object sender, RoutedEventArgs e)
        //{
        //    if (CurrentScene != CVScene.Courses)
        //    {
        //        //Go to the Courses page
        //        _mainFrame.NavigationService.Navigate(new Pages.Courses());
        //        LastScene = CurrentScene;
        //        CurrentScene = CVScene.Courses;
        //        ButtonControl();
        //    }
        //}
        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Home)
            {
                //Go to the Home page
                _mainFrame.NavigationService.Navigate(new Pages.MainPage());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Home;
                ButtonControl();
            }
        }
        private void BtnAchievements_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Achievements)
            {
                //Go to the Achievements page
                _mainFrame.NavigationService.Navigate(new Pages.Achievements());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Achievements;
                ButtonControl();
            }
        }
        private void BtnLB_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.LB)
            {
                //Go to to the LeaderBoards page
                _mainFrame.NavigationService.Navigate(new Pages.Leaderboards());
                LastScene = CurrentScene;
                CurrentScene = CVScene.LB;
                ButtonControl();
            }
        }
        private void BtnAccount_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Account)
            {
                //Go to the account page
                _mainFrame.NavigationService.Navigate(new Pages.Account());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Account;
                ButtonControl();
            }
        }
        private void BtnShop_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Shop)
            {
                //Go to the Shop page
                _mainFrame.NavigationService.Navigate(new Pages.Shop());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Shop;
                ButtonControl();
            }
        }
        private void BtnNews_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.News)
            {
                //Go to the News page
                _mainFrame.NavigationService.Navigate(new Pages.News());
                LastScene = CurrentScene;
                CurrentScene = CVScene.News;
                ButtonControl();
            }
        }
        private void BtnLanguages_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Languages)
            {
                //Go to the Languages page
                _mainFrame.NavigationService.Navigate(new Pages.Languages());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Languages;
                ButtonControl();
            }
        }
        private void BtnProgress_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Progress)
            {
                //Go to the Progress page
                _mainFrame.NavigationService.Navigate(new Pages.Progress());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Progress;
                ButtonControl();
            }
        }
        private void BtnDonate_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Donate)
            {
                //Go to the Settings Donate page
                _mainFrame.NavigationService.Navigate(new Pages.Donate());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Donate;
                ButtonControl();
            }
        }
        private void BtnKids_Click(object sender, RoutedEventArgs e)
        { 
            if (CurrentScene != CVScene.Kids)
            {
                //Go to the Kids page
                _mainFrame.NavigationService.Navigate(new Pages.Kids());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Kids;
            }
        }
        private void BtnSett_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Settings)
            {
                //Go to the Settings page
                _mainFrame.NavigationService.Navigate(new Pages.Settings());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Settings;
                ButtonControl();
            }

        }
        private void BtnWebsite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://website000020190624120045.azurewebsites.net/");
        }
        private void BtnCompiler_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentScene != CVScene.Compiler)
            {
                //Go to the Settings page
                _mainFrame.NavigationService.Navigate(new Pages.Compiler());
                LastScene = CurrentScene;
                CurrentScene = CVScene.Compiler;
                ButtonControl();
            }
        }


        #endregion
            //private bool isSpinning = false;
        private void BtnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            //if (!isSpinning)
            //{
            //    isSpinning = true;

            //    DoubleAnimation dblAnim = new DoubleAnimation();
            //    dblAnim.Completed += (o, s) => { isSpinning = false; };     
            //    dblAnim.From = 120;
            //    dblAnim.To = 0;

            //    ActualWidth;
            //    BtnHome.RenderTransform = rt;

            //    rt.BeginAnimation(RotateTransform.AngleProperty, dblAnim);
            //}
        }

       
    }
}
