using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IkWilEindApplicatie
{
    class Account
    {

        //fields
        private int accountID;
        private int ikwilID;
        private int teamleiderID;
        private int begeleiderID;
        private string gebruikersnaam;
        private string wachtwoord;

        //properties
        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
        public int IkWilID
        {
            get { return ikwilID; }
            set { ikwilID = value; }
        }
        public int BegeleiderID
        {
            get { return begeleiderID; }
            set { begeleiderID = value; }
        }

        public int TeamleiderID
        {
            get { return teamleiderID; }
            set { teamleiderID = value; }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        //constructor
        public Account(int AccountID, int IkWilID, int TeamleiderID, int BegeleiderID, string Gebruikersnaam, string Wachtwoord)
        {
            this.accountID = AccountID;
            this.ikwilID = IkWilID;
            this.teamleiderID = TeamleiderID;
            this.begeleiderID = BegeleiderID;
            this.gebruikersnaam = Gebruikersnaam;
            this.wachtwoord = Wachtwoord;
        }
    }
}
