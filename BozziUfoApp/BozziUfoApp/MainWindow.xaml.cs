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

namespace BozziUfoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Avvistamenti avvistamenti;

        public MainWindow()
        {
            InitializeComponent();

            // allocazione dell'oggetto che gestisce i file
            avvistamenti = new Avvistamenti();
            DgrElenco.ItemsSource = avvistamenti.Elenco;
        }

        private void BtnCaricaDati_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int quantitàDatiLetti = avvistamenti.LeggiDati("ufo-sightings-transformed.csv");
                LblDatiLetti.Content = quantitàDatiLetti + " record letti";
                DgrElenco.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
