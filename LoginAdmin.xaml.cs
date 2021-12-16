using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace complaintBox
{
    /// <summary>
    /// Interaction logic for LoginAdmin.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void loginBtn(object sender, RoutedEventArgs e)
        {
            String name;
            String Uname = textBoxName.Text;
            String ID = id.Text;
            String hash = GenerateHash(passWord.Password.ToString());
            System.Data.SqlClient.SqlConnection Cn = new SqlConnection(@connection.connectionString);
            String query = "select [dbo].[ADMIN_Login](" + ID + ", '" + hash + "')";
            SqlCommand cmd = new SqlCommand(query, Cn);
            Cn.Open();
            var queryResult = cmd.ExecuteScalar();
            if (Convert.ToString(queryResult).Length > 0)
            {
                ID = id.Text;
                name = Convert.ToString(queryResult);
                HomePageAdmin logged = new HomePageAdmin(ID, name);
                logged.Show();
                this.Close();
            }
            else
                MessageBox.Show("Invalid Credentials ! ");

        }

        private void signUpBtn(object sender, RoutedEventArgs e)
        {

            if (textBoxName.Text.Length < 1)
            {
                MessageBox.Show("Name is required for Signup");
                return;
            }

            String hash = GenerateHash(passWord.Password.ToString());
            SqlConnection Cn = new SqlConnection(@connection.connectionString);
            String query = "insert into Admin(name,id,pass)values(@name,@id,@pass)";
            SqlCommand cmd = new SqlCommand(query, Cn);
            cmd.Parameters.AddWithValue("@name",textBoxName.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            cmd.Parameters.AddWithValue("@pass", hash);
            Cn.Open();
            try
            {
                int r = cmd.ExecuteNonQuery();
                Cn.Close();
                if (r == 1)
                {
                    MessageBox.Show("values inserted");

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Cn.Close();
            }
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        static String GenerateHash(String Data)
        {
            using (SHA256 h = SHA256.Create())
            {
                byte[] bytes = h.ComputeHash(Encoding.UTF8.GetBytes(Data));
                StringBuilder b = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    b.Append(bytes[i].ToString("X2"));
                }
                return b.ToString();
            }
        }

        private void backkey(object sender, RoutedEventArgs e)
        {

            Window1 main = new Window1();
            main.Show();
            this.Close();

        }
    }
}
