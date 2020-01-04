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
    /// Interaction logic for wndFinancienKeuze.xaml
    /// </summary>
    public partial class wndFinancienKeuze : Window
    {
        public wndFinancienKeuze()
        {
            InitializeComponent();
        }

        private void BtnInkomsten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndInkomsten inkomstenwindow = new wndInkomsten();
            inkomstenwindow.ShowDialog();
        }

        private void BtnLoon_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndLoon loonwindow = new wndLoon();
            loonwindow.ShowDialog();
        }

        private void BtnUitgaven_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndUitgaven uitgavenwindow = new wndUitgaven();
            uitgavenwindow.ShowDialog();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndKeuze keuzewindow = new wndKeuze();
            keuzewindow.ShowDialog();
        }
    }
}
