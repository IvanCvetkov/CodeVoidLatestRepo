using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MaterialDesignThemes.Wpf;
using System.Windows;

namespace CodeVoidWPF
{

    public enum SettingsEnum { HasLoggedIn = 0, ColorMode = 1, NtMissedLession = 2, NtShop = 3, DarkMode = 4 }

    class SettingsSaver
    {
        [Serializable]
        class DataTemplate
        {
            public Dictionary<SettingsEnum, string> settings;
        }


        Dictionary<SettingsEnum, string> settings;

        public SettingsSaver()
        {
            //Check for the 'Data' folder
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "/Data"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Data");

            //Init the dictionary
            settings = new Dictionary<SettingsEnum, string>()
            {
                { SettingsEnum.HasLoggedIn, "False" },
                { SettingsEnum.ColorMode, "1" },
                { SettingsEnum.NtMissedLession, "True" },
                { SettingsEnum.NtShop, "True" },
                { SettingsEnum.DarkMode, "False" }
            };

            //Load the settings file
            LoadSettingsFile();

            //Set the Settings
            SetDarkMode();
        }
        /// <summary>
        /// Adds/Sets a value in the settings file.
        /// </summary>
        /// <param name="sett"></param>
        /// <param name="value"></param>
        public void AddValue(SettingsEnum sett, string value) => settings[sett] = value;
        //Gets a value in the settings file.
        public string GetValue(SettingsEnum sett) => settings[sett];
        /// <summary>
        /// Saves the settings.
        /// </summary>
        public void SaveSettings(bool saveSer = false)
        {
            if (saveSer)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(Directory.GetCurrentDirectory() + "/Data/settings.st");
                DataTemplate data = new DataTemplate
                {
                    settings = settings
                };

                bf.Serialize(file, data);
            }
            else
            {
                StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() + "/Data/settings.st");
                file.WriteLine("BC");
                file.WriteLine("#KEY:VALUE");
                foreach (KeyValuePair<SettingsEnum, string> item in settings)
                {
                    file.WriteLine("{0}:{1}", item.Key, item.Value);
                }
                file.Close();
            }
        }
        /// <summary>
        /// Loads the settings file.
        /// </summary>
        public void LoadSettingsFile()
        {
            if (settings == null)
                settings = new Dictionary<SettingsEnum, string>()
                {
                    { SettingsEnum.HasLoggedIn, "False" },
                    { SettingsEnum.ColorMode, "1" },
                    { SettingsEnum.NtMissedLession, "True" },
                    { SettingsEnum.NtShop, "True" },
                    { SettingsEnum.DarkMode, "False" }
                };

            if(!File.Exists(Directory.GetCurrentDirectory() + "/Data/settings.st"))
            {
                SaveSettings();
                return;
            }

            string[] fileSettings = File.ReadAllLines(Directory.GetCurrentDirectory() + "/Data/settings.st");
            if (!fileSettings[0].StartsWith("BC") || !fileSettings[0].StartsWith("NE"))
            {
                foreach(string s in fileSettings)
                {
                    bool setLine = false;
                    string line = "";
                    if (s.Contains("\t"))
                    {
                        line = s.Replace("\t", "");
                        setLine = true;
                    }

                    if(s.Contains(" "))
                    {
                        line = s.Replace(" ", "");
                        setLine = true;
                    }

                    if (!setLine) line = s;
                    

                    if(!line.StartsWith("#"))
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if(line.StartsWith(((SettingsEnum)i).ToString()))
                            {
                                string d = line.Replace(((SettingsEnum)i).ToString() + ":", "");
                                AddValue((SettingsEnum)i, d);
                            }
                        }
                    }
                }
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Directory.GetCurrentDirectory() + "/Data/settings.st", FileMode.Open);
                DataTemplate data = (DataTemplate)bf.Deserialize(file);
                file.Close();

                settings = data.settings;
            }
        }
        public void SetDarkMode()
        {
            bool dm;
            try
            {
                dm = bool.Parse(settings[SettingsEnum.DarkMode]);
            }
            catch
            {
                MessageBox.Show("Wrong setting value for DarkMode!\nSetting it to the default value.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                AddValue(SettingsEnum.DarkMode, false.ToString());
                SaveSettings();
                dm = false;
            }

            new PaletteHelper().SetLightDark(dm);
            MainWindow.win.SetBar(dm);
        }
    }
}