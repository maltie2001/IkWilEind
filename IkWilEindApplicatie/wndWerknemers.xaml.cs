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

namespace IkWilEindApplicatie
{
    /// <summary>
    /// Interaction logic for wndWerknemers.xaml
    /// </summary>
    public partial class wndWerknemers : Window
    {
        public wndWerknemers()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndPersooneels persoonwindow = new wndPersooneels();
            persoonwindow.ShowDialog();
        }
        private void BtnAddAcc_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            wndAccountAanmaken addwindow = new wndAccountAanmaken();
            addwindow.ShowDialog();
        }

    }
}
