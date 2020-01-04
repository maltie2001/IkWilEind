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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace IkWilEindApplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            db = new Database();  //database instantiëren, object aanmaken
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string Gebruikersnaam = tbAccount.Text; //username is ingevulde username
            string Wachtwoord = pwBox.Password.ToString(); //password is ingevulde password

            bool succes = db.Login(Gebruikersnaam, Wachtwoord); //het is gelukt als login van de databse gelijk is aan deze tweee parameters

            if (succes) //als het dus gelukt is
            {
                MessageBox.Show("Inloggen gelukt!"); //laat messagebox zien met het is gelukt
                 Account currentUser = new Account (Gebruikersnaam, Wachtwoord);  //maak een klasse currentuser met als parameters de inlog

                this.Hide();
                wndKeuze keuzewindow = new wndKeuze();
                keuzewindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord onjuist."); //messagebox met de inlog is niet juist
            }
        }


    }

        
    
}
