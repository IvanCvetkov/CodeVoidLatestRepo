using System;
using System.IO;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Path = System.IO.Path;
//using System.Configuration;
//using System.Data.SqlClient;
//using System.Data;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : INotifyPropertyChanged
    {
        //SqlConnection connection;
        //string connectionString;

        //databinding interface
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Shop()
        {
            InitializeComponent();

            //DataContext = this;
            //connectionString = ConfigurationManager.ConnectionStrings
                //["Database1.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }


        //points
        private int _boundPointsNumber;
        public int boundPointsNumber
        {
            get { return _boundPointsNumber; }
            set
            {
                if (_boundPointsNumber != value)
                {
                    _boundPointsNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _boundAchievements;
        public int boundAchievements
        {
            get { return _boundAchievements; }
            set
            {
                if (_boundAchievements != value)
                {
                    _boundAchievements = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _boundProducts;
        public int boundProducts
        {
            get { return _boundProducts; }
            set
            {
                if (_boundProducts != value)
                {
                    _boundProducts = value;
                    OnPropertyChanged();
                }
            }
        }


        //Database manager
        //private void DatabaseUpdate()
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("*SELECT * FROM Table", connection))
        //    {
        //        connection.Open();

        //        DataTable table = new DataTable();
        //        adapter.Fill(table);

        //        Balance.Text = table.ToString();
        //    }
        //}

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //...DatabaseUpdate();
            

            string[] points = { "15", "20", "30" };

            //Introduction shop logic
            string desktop_Path =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathIntroduction = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/Introduction.txt";
            string introductionPath = Path.Combine(desktop_Path, pathIntroduction);

            if (File.ReadAllText(introductionPath).Contains(points[0]))
            {
                boundPointsNumber += int.Parse(points[0]);
            }

            //variables shop logic
            string pathVariables = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/Variables.txt";
            string variablesPath = Path.Combine(desktop_Path, pathVariables);

            if (File.ReadAllText(variablesPath).Contains(points[1]))
            {
                boundPointsNumber += int.Parse(points[1]);
            }


            //Money display logic
            string[] separators = { "/50", "/15" };

            Products.Text = boundProducts + separators[0];
            Achievements.Text += boundAchievements + separators[1];
            Balance.Text += boundPointsNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnBackShop_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }


    }
}