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
    /// Interaction logic for wndLoon.xaml
    /// </summary>
    public partial class wndLoon : Window
    {
        public wndLoon()
        {
            InitializeComponent();
            connectie();
        }
        BasicDatabase deDatabase = new BasicDatabase("Loon", "IKWILFINAL");
        private void connectie()
        {
            deDatabase.connect();
            dgLoon.ItemsSource = deDatabase.dt.DefaultView;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndFinancienKeuze financienkeuzewindow = new wndFinancienKeuze();
            financienkeuzewindow.ShowDialog();
        }
        
    }
}
