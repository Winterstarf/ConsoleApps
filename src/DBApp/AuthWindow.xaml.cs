using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace DBApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordPasswordBox.Password;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QLMK9N;Initial Catalog=Rool;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from UserData where Username='" + username + "' and Pass='" + password + "'", con);
            cmd.CommandType = System.Data.CommandType.Text;

            object result = cmd.ExecuteScalar();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

            else if ((username == "" || username == null) && (password == "" || password == null))
            {
                MessageBox.Show("Логин и пароль не введены");
            }

            else if (username == "" || username == null)
            {
                MessageBox.Show("Логин не введён");
            }

            else if (password == "" || password == null)
            {
                MessageBox.Show("Пароль не введён");
            }

            else
            {
                MessageBox.Show("Аккаунт не найден");
            }

            con.Close();
        }
    }
}
