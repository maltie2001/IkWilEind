using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IkWilEindApplicatie
{
    class Begeleider
    {
        //fields
        private int begeleiderID;
        private int accountID;
        private string voornaam;
        private string achternaam;
        private string adres;
        private int telefoonnr;

        //properties
        public int BegeleiderID
        {
            get { return begeleiderID; }
            set { begeleiderID = value; }
        }

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Telefoonnr
        {
            get { return telefoonnr; }
            set { telefoonnr = value; }
        }

        //constructor
        public Begeleider(int BegeleiderID, int AccountID, string Voornaam, string Achternaam, string Adres, int Telefoonnr)
        {
            this.begeleiderID = BegeleiderID;
            this.accountID = AccountID;
            this.voornaam = Voornaam;
            this.achternaam = Achternaam;
            this.adres = Adres;
            this.telefoonnr = Telefoonnr;
        }
    }
}
