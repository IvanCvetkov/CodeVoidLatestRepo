using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace CodeVoidWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        

        //Animation Methods
        public void AlertGridOpen()
        {
            //Grid
            DoubleAnimation alertGridAnim = new DoubleAnimation()
            {
                From = MinWidth,
                To = 800,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertGrid.BeginAnimation(WidthProperty, alertGridAnim);

            //Border
            DoubleAnimation border = new DoubleAnimation()
            {
                From = MinWidth,
                To = 800,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertBorder.BeginAnimation(WidthProperty, border);
        }
        public async void AlertGridClose()
        {
            //Grid
            DoubleAnimation alertGridAnim = new DoubleAnimation()
            {
                From = 800,
                To = MinWidth,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertGrid.BeginAnimation(WidthProperty, alertGridAnim);

            //Border
            DoubleAnimation border = new DoubleAnimation()
            {
                From = 800,
                To = MinWidth,
                Duration = TimeSpan.FromSeconds(1),

                EasingFunction = new QuinticEase()
            };

            AlertBorder.BeginAnimation(WidthProperty, border);

            await Task.Delay(1000);

            this.Close();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {


            bool passw = false;
            string strUsername = username.Text;
            string strPass = pass.Text;
            string ConString = " datasource = localhost; port = 3306; username = root; password =";

            string sql = "SELECT COUNT(*) FROM codevoidlogin.test WHERE username = @userlog";
            string sql2 = "SELECT COUNT(*) FROM codevoidlogin.test WHERE password = @password";
            using (MySqlConnection cnPass = new MySqlConnection(ConString))
            {
                cnPass.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql2, cnPass))
                {
                    cmd.Parameters.AddWithValue("@password", strPass);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        passw = true;
                    }
                    else
                    {
                        passw = false;
                    }
                }
            }

            using (MySqlConnection cn = new MySqlConnection(ConString))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@userlog", strUsername);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0 && passw == true)
                    {
                        //MessageBox.Show("Login successful!", "Login");
                        LoginSuccess ls = new LoginSuccess();
                        ls.ShowDialog();
                    }
                    else
                    {
                        //MessageBox.Show("Login FAILED!", "ERROR");
                        LoginAlert la = new LoginAlert();
                        la.ShowDialog();
                    }
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AlertGridOpen();
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            AlertGridClose();
        }

        private void Pass_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (pass.Text == "Password")
                pass.Clear();
            
            if (string.IsNullOrEmpty(username.Text))
                username.Text = "Username";
        }

        private void Username_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (username.Text == "Username")
                username.Clear();
            if (string.IsNullOrEmpty(pass.Text))
                pass.Text = "Password";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}