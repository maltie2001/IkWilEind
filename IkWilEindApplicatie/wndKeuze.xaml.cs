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

namespace IkWilEindApplicatie
{
    /// <summary>
    /// Interaction logic for wndKeuze.xaml
    /// </summary>
    public partial class wndKeuze : Window
    {
        public wndKeuze()
        {
            InitializeComponent();
        }

        private void BtnFinancieel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndFinancienKeuze financienkeuzewindow = new wndFinancienKeuze();
            financienkeuzewindow.ShowDialog();
        }

        private void BtnPersoneel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndPersooneels persoonwindow = new wndPersooneels();
            persoonwindow.ShowDialog();
        }
    }
}
