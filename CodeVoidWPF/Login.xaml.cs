using MySql.Data.MySqlClient;
using System;
using System.Windows;

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

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            string insertQuery = "INSERT INTO codevoidlogin.test(username,password,mail) VALUES(@username,@password,@mail)";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@username", username.Text);
            command.Parameters.AddWithValue("@password", password.Text);
            command.Parameters.AddWithValue("@mail", mail.Text);


            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

            //MySqlDataReader rd = command.ExecuteReader();
            //while (rd.Read())
            //{
            //    if (rd.ToString() == username.Text)
            //    {
            //        MessageBox.Show("The username already exists!");
            //    }
            //}
            //connection.Close();
        }
    }
}
