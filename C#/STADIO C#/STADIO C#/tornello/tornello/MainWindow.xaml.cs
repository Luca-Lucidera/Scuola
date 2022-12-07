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
using System.Windows.Threading;

namespace tornello
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biglietteria b;
        string evento;
        public MainWindow()
        {
            InitializeComponent();
            evento = "";
            b = new Biglietteria();
            DispatcherTimer time = new DispatcherTimer();
            lbl_orario.Content = DateTime.Now.ToLongTimeString();
            time.Interval = TimeSpan.FromSeconds(1);
            time.Tick += tempo_Tick;
            time.Start();
            b.setPercorsoEventi(@"..\..\..\..\eventi2.txt");
            b.caricaEventi();
            b.setNomeFile(@"..\..\..\..\biglietti2.txt");
            b.caricaFile();
            for (int i = 0; i < b.getLunghezza(); i++)
            {
                comboEventi.Items.Add(b.getEventiDaPosizione(i));
            }
        }
        void tempo_Tick(object sender, EventArgs e)
        {
            lbl_orario.Content = DateTime.Now.ToLongTimeString();
        }
        private void QrWebCamControl_QrDecoded(object sender, string e)
        {
            string stringaLetta = e;
            b.caricaFile();
            if(b.qrEsistente(stringaLetta,evento) == 1)
            {
                if(b.giaPresente(stringaLetta)== false)
                {
                    b.aggiungiPersonaEntrata(stringaLetta);
                    lbl_persone_presenti.Content += /*p.cambiamiIlNome()*/e + "\n";
                    MessageBox.Show("BENVENUTO!");
                }
                else
                {
                    MessageBox.Show("ARRIVEDERCI!");
                }
                
            }
            lbl_persone_presenti.Content = b.visPerosnePresenti();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            combo_webcam.ItemsSource = webCam.CameraNames;
        }

        private void combo_webcam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            webCam.CameraIndex = combo_webcam.SelectedIndex;
        }

        private void comboEventi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            evento = b.getEventiDaPosizione(comboEventi.SelectedIndex);
            b.rimuoviTutti();
        }
    }
}
