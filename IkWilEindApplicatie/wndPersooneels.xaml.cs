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
    /// Interaction logic for wndPersooneels.xaml
    /// </summary>
    public partial class wndPersooneels : Window
    {
        public wndPersooneels()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndKeuze keuzewindow = new wndKeuze();
            keuzewindow.ShowDialog();
        }

        private void BtnPersoneel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndWerknemers werknemerwindow = new wndWerknemers();
            werknemerwindow.ShowDialog();
        }

        private void BtnCommunity_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndCommunityLid communitywindow = new wndCommunityLid();
            communitywindow.ShowDialog();
        }

        private void BtnEvenWork_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            wndEvenementWorkshop evenworkwindow = new wndEvenementWorkshop();
            evenworkwindow.ShowDialog();
        }
    }
}
