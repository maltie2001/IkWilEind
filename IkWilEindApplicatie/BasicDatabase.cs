using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace IkWilEindApplicatie
{
    public class BasicDatabase
    {
        string tabel;
        string database;
        public DataTable dt = new DataTable();

        public BasicDatabase(string tabel, string database)
            {
            this.tabel = tabel;
            this.database = database;
            }

        public BasicDatabase(string database)
        {
            this.database = database;
        }

        public void connect()
        {
            const string connectionString = @"Data Source=DESKTOP-2EJIEFC\SQLSERVERTEUN;Initial Catalog=IKWILFINAL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM " + tabel;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //dgLoon.ItemsSource = dt.DefaultView;
            }

            conn.Close();
        }

        private void Datageneratie()
        {

        }

    }

}
