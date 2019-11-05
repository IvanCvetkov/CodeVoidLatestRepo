using MaterialDesignThemes.Wpf;
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

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        SettingsSaver settingsSaver;
        public Settings()
        {
            InitializeComponent();
            //Load the settings into the controls
            settingsSaver = new SettingsSaver();
            SetControls();
        }

        void SetControls()
        {
            string darkMode = settingsSaver.GetValue(SettingsEnum.DarkMode);
            try
            {
                DarkModeTgl.IsChecked = bool.Parse(darkMode);
            }
            catch
            {
                MessageBox.Show("Wrong setting value for DarkMode!\nSetting it to the default value.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                DarkModeTgl.IsChecked = false;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }

        private void DarkModeTgl_Click(object sender, RoutedEventArgs e)
        {
            settingsSaver.AddValue(SettingsEnum.DarkMode, DarkModeTgl.IsChecked.Value.ToString());
            settingsSaver.SetDarkMode();
            settingsSaver.SaveSettings();
        }
        /// <summary>
        /// 'Go Back' Button
        /// </summary>
        private void BtnBackSettings_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }

        private void DarkModeTgl_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
