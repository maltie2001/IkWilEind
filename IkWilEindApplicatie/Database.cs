using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IkWilEindApplicatie
{
    public class Database
    {
        //connectionstring declareren
        SqlConnection conn;
        string connString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=FINALikwil;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //const string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=FINALikwil;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Database()
        {
            //nieuwe connectie aanmaken
            conn = new SqlConnection(connString);

        }
        //internal SqlConnection SqlConnection { get; }

        public bool Login(string Gebruikersnaam, string Wachtwoord)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE Gebruikersnaam = @id AND Wachtwoord = @password", conn);
                //selecteer alles van de tabel gebruiker waar gebruikersid en ww gelijk is aan wat is ingevuld
                command.Parameters.AddWithValue("@id", Gebruikersnaam); // Er kan niets anders dan alleen een id meegegeven worden
                command.Parameters.AddWithValue("@password", Wachtwoord); // Er kan niets anders dan alleen een ww meegegeven worden

                var result = command.ExecuteScalar();//Geeft 1 regel terug
                if (result != null)
                {
                    return true;
                }

                conn.Close();
                return false;
            }
        }
    }
}
