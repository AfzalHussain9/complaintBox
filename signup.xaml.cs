using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

namespace complaintBox
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3() {
            InitializeComponent();
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String hash = GenerateHash(passWord.Password.ToString());
            
            System.Data.SqlClient.SqlConnection Cn = new SqlConnection(@connection.connectionString);
            String query = "insert into users(id,pass,name,dep_id)values(@id,@pass,@name,@department)";
            SqlCommand cmd = new SqlCommand(query, Cn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            cmd.Parameters.AddWithValue("@pass", hash);
            cmd.Parameters.AddWithValue("@name",name.Text);
            cmd.Parameters.AddWithValue("@department", Department.SelectedIndex);
            name.Text = hash;
            Cn.Open();
            try {
                int r = cmd.ExecuteNonQuery();
                Cn.Close();
                if (r == 1)
                {
                    MessageBox.Show("values inserted");
                }
            }catch (Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show(error.Message);
            }finally {
                Cn.Close();
            }
        }

        private void backKey_Click(object sender, RoutedEventArgs e) {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
