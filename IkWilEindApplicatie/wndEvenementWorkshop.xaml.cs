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
    /// Interaction logic for wndEvenementWorkshop.xaml
    /// </summary>
    public partial class wndEvenementWorkshop : Window
    {
        
        public wndEvenementWorkshop()
        {
            InitializeComponent();
            
        }



        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndPersooneels persoonwindow = new wndPersooneels();
            persoonwindow.ShowDialog();
        }
        
        private void CbSoort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (cbSoort.SelectedIndex == 0)
            {

                BasicDatabase evenementDatabase = new BasicDatabase("evenement", "IKWILFINAL");
                void connectie()
                {
                    dgEvenWork.ItemsSource = null;
                    evenementDatabase.connect();
                    dgEvenWork.ItemsSource = evenementDatabase.dt.DefaultView;
                }
                connectie();

            }
            else
            {
                BasicDatabase workshopDatabase = new BasicDatabase("workshop", "IKWILFINAL");
                void connectie()
                {
                    dgEvenWork.ItemsSource = null;
                    workshopDatabase.connect();
                    dgEvenWork.ItemsSource = workshopDatabase.dt.DefaultView;
                }
                connectie();
                tbTest.Text = "Workshop Test";
            }
        }
    }
}
