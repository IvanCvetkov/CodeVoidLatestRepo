using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace CodeVoidWPF
{
    using UserDB.Encryption;
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }



        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string strUser = username.Text;
            string strPassPlain = pass.Text;
            string strMail= mail.Text;

            PasswordEncryptor keys = new PasswordEncryptor();
            string strPass = keys.EncryptString(strPassPlain);


            bool passw = false;
            bool ending = false;
            bool mailb = false;
            string ConString = " datasource = localhost; port = 3306; username = root; password =";

            string sql = "SELECT COUNT(*) FROM codevoidlogin.actualdatabase WHERE username = @userlog";
            string sql2 = "SELECT COUNT(*) FROM codevoidlogin.actualdatabase WHERE password = @password";
            string sql3 = "SELECT COUNT(*) FROM codevoidlogin.actualdatabase WHERE mail = @mail";
            using (MySqlConnection cnPass = new MySqlConnection(ConString))
            {
                cnPass.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql2, cnPass))
                {
                    cmd.Parameters.AddWithValue("@password", strPass);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        passw = false;
                    }
                    else
                    {
                        passw = true;
                    }
                }
            }

            using (MySqlConnection cn = new MySqlConnection(ConString))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@userlog", strUser);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0 && passw == true)
                    {
                        //MessageBox.Show("Login successful!", "Login");
                    }
                    else
                    {
                        //MessageBox.Show("Login FAILED!", "ERROR");
                        ending = true;
                    }
                }
            }

            using (MySqlConnection cnMail = new MySqlConnection(ConString))
            {
                cnMail.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql3, cnMail))
                {
                    cmd.Parameters.AddWithValue("@mail", strMail);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        mailb = false;
                    }
                    else
                    {
                        mailb = true;
                    }
                }
            }

            if (firstName.Text != "First name" && firstName.Text != null
                && lastName.Text != "Last name" && lastName.Text != null
                && username.Text != "Username" && username.Text != null
                && pass.Text != "Password" && pass.Text != null
                && mail.Text != "E-Mail" && mail.Text != null)
            {
                if (mailb == true)
                {
                    if (strUser.Length >= 6 && strPass.Length >= 6)
                    {
                        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                        string insertQuery = "INSERT INTO codevoidlogin.actualdatabase(username,password,mail,firstname,lastname)" +
                            " VALUES(@username,@password,@mail,@firstname,@lastname)";

                        if (ending == true)
                        {
                            connection.Open();
                            MySqlCommand command = new MySqlCommand(insertQuery, connection);
                            command.Parameters.AddWithValue("@firstname", firstName.Text);
                            command.Parameters.AddWithValue("@lastname", lastName.Text);
                            command.Parameters.AddWithValue("@username", strUser);
                            command.Parameters.AddWithValue("@mail", strMail);
                            command.Parameters.AddWithValue("@password", strPass);
                            try
                            {
                                if (command.ExecuteNonQuery() == 1)
                                {

                                    // MessageBox.Show("You have registered successfully!");
                                    RegisterSuccess registerSuccess = new RegisterSuccess();
                                    registerSuccess.ShowDialog();
                                }
                                else
                                {

                                    // MessageBox.Show("Registration failed!");
                                    RegisterAlert registerAlert = new RegisterAlert();
                                    registerAlert.ShowDialog();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            connection.Close();
                            ending = false;
                        }
                    }
                    else
                    {
                        RegisterAlert registerAlert = new RegisterAlert();
                        registerAlert.ShowDialog();
                    }
                }
                else
                {
                    EmailAlert emailAlert = new EmailAlert();
                    emailAlert.ShowDialog();
                }
            }
            else
            {
                RegisterFieldsAlert registerFieldsAlert = new RegisterFieldsAlert();
                registerFieldsAlert.ShowDialog();
            }
        }

        //*****//
        //MODEL//
        //*****//
        /*if (string.IsNullOrEmpty(pass.Text))
            pass.Text = "Password";
        if (string.IsNullOrEmpty(username.Text))
            username.Text = "Username";
        if (string.IsNullOrEmpty(firstName.Text))
            firstName.Text = "First name";
        if (string.IsNullOrEmpty(firstName.Text))
            firstName.Text = "Last name";
        if (string.IsNullOrEmpty(mail.Text))
            mail.Text = "E-Mail";*/

        private void Pass_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (pass.Text == "Password")
                pass.Clear();

            if (string.IsNullOrEmpty(username.Text))
                username.Text = "Username";
            if (string.IsNullOrEmpty(firstName.Text))
                firstName.Text = "First name";
            if (string.IsNullOrEmpty(lastName.Text))
                lastName.Text = "Last name";
            if (string.IsNullOrEmpty(mail.Text))
                mail.Text = "E-Mail";
        }

        private void Username_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (username.Text == "Username")
                username.Clear();

            if (string.IsNullOrEmpty(pass.Text))
                pass.Text = "Password";
            if (string.IsNullOrEmpty(firstName.Text))
                firstName.Text = "First name";
            if (string.IsNullOrEmpty(lastName.Text))
                lastName.Text = "Last name";
            if (string.IsNullOrEmpty(mail.Text))
                mail.Text = "E-Mail";

        }

        private void Mail_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (mail.Text == "E-Mail")
                mail.Clear();

            if (string.IsNullOrEmpty(pass.Text))
                pass.Text = "Password";
            if (string.IsNullOrEmpty(username.Text))
                username.Text = "Username";
            if (string.IsNullOrEmpty(firstName.Text))
                firstName.Text = "First name";
            if (string.IsNullOrEmpty(lastName.Text))
                lastName.Text = "Last name";

        }

        private void Firstname_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (firstName.Text == "First name")
                firstName.Clear();

            if (string.IsNullOrEmpty(pass.Text))
                pass.Text = "Password";
            if (string.IsNullOrEmpty(username.Text))
                username.Text = "Username";
            if (string.IsNullOrEmpty(lastName.Text))
                lastName.Text = "Last name";
            if (string.IsNullOrEmpty(mail.Text))
                mail.Text = "E-Mail";
        }

        private void Lastname_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (lastName.Text == "Last name")
                lastName.Clear();

            if (string.IsNullOrEmpty(pass.Text))
                pass.Text = "Password";
            if (string.IsNullOrEmpty(username.Text))
                username.Text = "Username";
            if (string.IsNullOrEmpty(firstName.Text))
                firstName.Text = "First name";
            if (string.IsNullOrEmpty(mail.Text))
                mail.Text = "E-Mail";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
