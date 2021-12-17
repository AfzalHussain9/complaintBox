using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient;

namespace complaintBox
{
    /// <summary>
    /// Interaction logic for HomePageUser.xaml
    /// </summary>
    public partial class loggedin : Window
    {
        private String ID;
        private String Name;


        public loggedin(String val, String Name)
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            date.Content = dt.ToString();
            this.ID = val;
            id.Content = ID;
            this.Name = Name; ;
            name.Content = Name;
            fill_departments();
            fill_complains();

        }

        private void fill_complains()
        {
            
            SqlConnection connection = new SqlConnection(complaintBox.connection.connectionString);
            SqlCommand command = new SqlCommand("COMPLAINTS", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            

            SqlDataReader reader = command.ExecuteReader();
      

            while (reader.Read())
            {
                String name = reader["Name"].ToString();

                complaintType.Items.Add(name);
            }
        }

        private void fill_departments()
        {

            SqlConnection connection = new SqlConnection(complaintBox.connection.connectionString);

            SqlCommand command = new SqlCommand("DEPARTMENTS", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            //var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();


            // if(Convert.ToInt32(returnParameter.Value) == 1)
            //{

            //    MessageBox.Show("Database Error occurred");

            //}

            while (reader.Read())
            {
                String name = reader["Name"].ToString();

                Department.Items.Add(name);
            }

        }

        
        string StringFromRichTextBox(RichTextBox complaintBox)
        {
            TextRange textRange = new TextRange(
                
                complaintBox.Document.ContentStart,
                
                complaintBox.Document.ContentEnd
            );

            return textRange.Text;
        }

        private void submitBtnClicked(object sender, RoutedEventArgs e)
        {
            try
            {


                SqlConnection connection = new SqlConnection(complaintBox.connection.connectionString);
                SqlCommand command = new SqlCommand("ADD_TICKET", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@user_id", this.ID);
                command.Parameters.AddWithValue("@dep_id", Department.SelectedIndex);
                command.Parameters.AddWithValue("@CType", complaintType.SelectedIndex);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.Parameters.AddWithValue("@description", StringFromRichTextBox(complainBox));

                connection.Open();

                int result = command.ExecuteNonQuery();

                MessageBox.Show(result == 1 ? "Value Inserted" : "Failed to add values");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void logoutBtnClicked(object sender, RoutedEventArgs e)
        {
            Window1 main = new Window1();
            main.Show();
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

    }


}
