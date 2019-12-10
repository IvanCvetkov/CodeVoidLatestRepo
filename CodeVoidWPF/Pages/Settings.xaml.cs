using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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

            //RTB functionality
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string settingsPath = desktopPath + "\\CodeVoidProject\\CodeVoid\\CodeVoidWPF\\bin\\Debug\\Data\\DarkModeFix.txt";
            if (DarkModeTgl.IsChecked == true)
                using (StreamWriter sr = new StreamWriter(settingsPath))
                {
                    if (!File.Exists(settingsPath))
                        File.Create(settingsPath);

                    if (File.Exists(settingsPath))
                    {
                        string line = "DarkMode:True";
                        sr.WriteLine(line);
                    }
                }
            if (DarkModeTgl.IsChecked == false)
                using (StreamWriter sr = new StreamWriter(settingsPath))
                {
                    if (!File.Exists(settingsPath))
                        File.Create(settingsPath);

                    if (File.Exists(settingsPath))
                    {
                        string line = "DarkMode:False";
                        sr.WriteLine(line);
                    }
                }
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