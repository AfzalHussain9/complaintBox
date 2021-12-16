using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace complaintBox
{
    /// <summary>
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void loginClick(object sender, RoutedEventArgs e)
        {
            String name;
            String ID = id.Text;
            String hash = GenerateHash(passWord.Password.ToString());
            SqlConnection Cn = new SqlConnection(@connection.connectionString);
            String query = "select [dbo].[U_Login]("+ID+", '"+hash+"')";
            SqlCommand cmd = new SqlCommand(query, Cn);
            Cn.Open();
            var queryResult = cmd.ExecuteScalar();
            if (Convert.ToString(queryResult).Length > 0)
            {
                ID = id.Text;
                name = Convert.ToString(queryResult);
                loggedin logged = new loggedin(ID, name);
                logged.Show();
                this.Close();
            }
            else
                MessageBox.Show("Invalid Credentials ! ");
        }
        private void closeBtn(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void signUpBtn(object sender, RoutedEventArgs e)
        {
            Window3 signup = new Window3();
            signup.Show();
            this.Close();


            /*
            String hash = GenerateHash(passWord.Password.ToString());
            System.Data.SqlClient.SqlConnection Cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sheraz Janjua\Documents\Visual Studio 2015\Projects\complaintBoxx-master\complaintBox\Database1.mdf;Integrated Security=True");
            String query = "insert into login(Id,Password)values(@a,@b)";
            SqlCommand cmd = new SqlCommand(query, Cn);
            cmd.Parameters.AddWithValue("@a", Convert.ToInt32(id.Text));
            cmd.Parameters.AddWithValue("@b", hash);
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
*/
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

        private void backKey_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = new Window1();
            main.Show();
            this.Close();

        }
    }

}

