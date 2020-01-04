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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace IkWilEindApplicatie
{
    /// <summary>
    /// Interaction logic for wndUitgaven.xaml
    /// </summary>
    public partial class wndUitgaven : Window
    {
        const string connectionString = @"Data Source=DESKTOP-2EJIEFC\SQLSERVERTEUN;Initial Catalog=IKWILFINAL;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        public wndUitgaven()
        {
            InitializeComponent();
            connectie();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndFinancienKeuze financienkeuzewindow = new wndFinancienKeuze();
            financienkeuzewindow.ShowDialog();
        }
        BasicDatabase deDatabase = new BasicDatabase("uitgaven", "IKWILFINAL");
        private void connectie()
        {
            deDatabase.connect();
            dgUitgaven.ItemsSource = deDatabase.dt.DefaultView;
        }
        
    }
}
