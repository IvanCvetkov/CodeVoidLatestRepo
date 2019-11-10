using System;
using System.Collections.Generic;
using System.IO;
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
using Path = System.IO.Path;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Page
    {
        int Shop_Points = 0;

        public Shop()
        {
            InitializeComponent();
        }

        private void BtnBackShop_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string[] points = { "15", "20", "30" };

            //Introduction shop logic
            string desktop_Path =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathIntroduction = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/Introduction.txt";
            string introductionPath = Path.Combine(desktop_Path, pathIntroduction);

            if (File.ReadAllText(introductionPath).Contains(points[0]))
            {
                    Shop_Points += int.Parse(points[0]);
            }

            //variables shop logic
            string pathVariables = "CodeVoidProject/CodeVoid/CodeVoidWPF/Points/Variables.txt";
            string variablesPath = Path.Combine(desktop_Path, pathVariables);

            if (File.ReadAllText(variablesPath).Contains(points[1]))
            {
                    Shop_Points += int.Parse(points[1]);
            }


            ShopBalance.Text += Shop_Points;
        }

    }
}
