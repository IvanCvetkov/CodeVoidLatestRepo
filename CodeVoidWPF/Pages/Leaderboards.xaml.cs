using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Globalization;

namespace CodeVoidWPF.Pages
{
    /// <summary>
    /// Interaction logic for Leaderboards.xaml
    /// </summary>
    public partial class Leaderboards : Page
    {
        public Leaderboards()
        {
            InitializeComponent();

            string Nation = RegionInfo.CurrentRegion.NativeName;

            //Basic scrollviewer test
            List<User> users = new List<User>();
            users.Add(new User() { Placement = 2, Nation = Nation, Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 16 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 17 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 35 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 38 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 67 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });
            users.Add(new User() { Placement = 1, Nation = "test", Name = "test", Score = 15 });


            users = users.OrderByDescending(x => x.Score).ToList();
            leaderboard.Items.Clear();
            leaderboard.ItemsSource = users;
        }
        public class User
        {
            public string Nation {get; set;}
            public int Placement { get; set; }
            public string Name { get; set; }
            public long Score { get; set; }
        }


        private void BtnBackLB_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.win.NavigateLast();
        }
    }
}