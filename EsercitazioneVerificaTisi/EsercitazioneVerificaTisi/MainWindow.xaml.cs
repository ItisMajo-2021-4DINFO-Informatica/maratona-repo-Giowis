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

namespace EsercitazioneVerificaTisi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ElencoMaratone Elenco;

        public MainWindow()
        {
            InitializeComponent();

            Elenco = new ElencoMaratone();
            DgDati.ItemsSource = Elenco.InsiemeMaratone;
        }

        private void BtnLeggi_Click(object sender, RoutedEventArgs e)
        {
            Elenco.LeggiDaFile();

            DgDati.Items.Refresh();
        }

        private void BtnCerca_Click(object sender, RoutedEventArgs e)
        {
            CercaNomeCittà();

            string Atleta = TxtAtleta;
            string Città = TxtCittà;
        }
    }
}
