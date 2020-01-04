using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IkWilEindApplicatie
{
    class Coordinator
    {
        //fields
        private int ikwilID;
        private int teamleiderID;
        private int accountID;
        private string voornaam;
        private string achternaam;
        private string adres;
        private string woonplaats;
        private string postcode;
        private string email;
        private int telefoonnr;

        //properties
        public int IkWilID
        {
            get { return ikwilID; }
            set { ikwilID = value; }
        }
        public int TeamleiderID
        {
            get { return teamleiderID; }
            set { teamleiderID = value; }
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
        public string Woonplaats
        {
            get { return woonplaats; }
            set { woonplaats = value; }
        }
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Telefoonnr
        {
            get { return telefoonnr; }
            set { telefoonnr = value; }
        }

        //constructor
        public Coordinator(int IkWilID, int TeamleiderID, int AccountID, string Voornaam, string Achternaam, string Adres, string woonplaats, string postcode, string email, int Telefoonnr)
        {
            this.ikwilID = IkWilID;
            this.teamleiderID = TeamleiderID;
            this.accountID = AccountID;
            this.voornaam = Voornaam;
            this.achternaam = Achternaam;
            this.adres = Adres;
            this.woonplaats = Woonplaats;
            this.postcode = Postcode;
            this.email = Email;
            this.telefoonnr = Telefoonnr;
        }
    }
}
