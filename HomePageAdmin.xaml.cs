using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace complaintBox
{
    /// <summary>
    /// Interaction logic for HomePageAdmin.xaml
    /// </summary>
    public partial class HomePageAdmin : Window
    {
        private String ID;
        private String Name;
        public HomePageAdmin()
        {
            InitializeComponent();
        }
        public HomePageAdmin(String val, String Name)
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            date.Content = dt.ToString();
            this.ID = val;
            id.Content = "ID: "+ID;
            this.Name = Name; ;
            name.Content = "Name: "+Name;

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnGetData_Click(object sender, RoutedEventArgs e) 
        {
            data_grid.Visibility = Visibility.Visible;
            try
            {
                SqlConnection Cn = new SqlConnection(@connection.connectionString);
                DataTable dataTable = new DataTable();
                Cn.Open();
                if (Cn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("TICKETS", Cn);


                    cmd.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();

                    SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                    sqlAdapter.SelectCommand = cmd;

                    sqlAdapter.Fill(ds);

                    data_grid.ItemsSource = ds.Tables[ds.Tables.Count-1].DefaultView;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

       
        private void dbChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid) sender;
            DataRowView rowSelected = gd.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Yes = "Solved";
                MessageBoxManager.No = "Pending";
                MessageBoxManager.Cancel = "Delete";
                MessageBoxManager.Register();
                MessageBoxResult result = MessageBox.Show("Update Status of Repeat ID "+rowSelected["id"].ToString()+"?", "Update Status", MessageBoxButton.YesNoCancel);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Solved !", "My App");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Added to pending", "My App");
                        break;
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("Deleted", "My App");
                        break;
                }
            }
        }
        private void logoutBtn(object sender, RoutedEventArgs e)
        { 
            Window1 window = new Window1();
            window.Show();
            Close();
        }
    }
}