using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complaintBox
{
    class connection
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTS\CSharp\Afzal ComplaintBox\Database.mdf;Integrated Security=True;Connect Timeout=30";
        public static void connect()
        {
            SqlConnection Cn = new SqlConnection(@connectionString);
        }
    }
}
