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
using System.Windows.Threading;

namespace Accesso_alla_palestra
{
    /// <summary>
    /// Logica di interazione per finestra_accedi.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Palestra p;       
        public MainWindow()
        {
            InitializeComponent();
            p = new Palestra();
            p.setPercorsoFile(@"C:\Users\lucid\Desktop\QR PALESTRA FINALE\QR_PALESTRA\QR_PALESTRA\iscritti.txt");
            web.Navigate(@"C:\Users\lucid\Desktop\QR PALESTRA FINALE\Accesso_alla_palestra\benvenuti.html");
            p.carica();
            DispatcherTimer tempo = new DispatcherTimer();
            //ogni quanto  tempo ripete 
            tempo.Interval = TimeSpan.FromSeconds(1);
            tempo.Tick += tempo_Tick;
            tempo.Start();
        }
        void tempo_Tick(object sender, EventArgs e)
        {
            lbl_tempo.Content = DateTime.Now.ToLongTimeString();
        }
        private void camSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            webCam.CameraIndex = camSelect.SelectedIndex;
        }

        private void QrWebCamControl_QrDecoded(object sender, string e)
        {
            p.carica();
            if (p.controllaSeEsiste(e) != "qr inesistente")
            {
                int posTmp = p.vuoleUscire(e); //controllo se la persona è già dentro nella palestra
                if (posTmp != -1) //se è dentro
                {
                    p.ArriveCIAO(posTmp); //toglie la persona
                    MessageBox.Show("Arrivederci " + e); //messaggio per bloccare l'esecuzione
                    web.Navigate(@"C:\Users\lucid\Desktop\QR PALESTRA FINALE\Accesso_alla_palestra\benvenuti.html");
                }
                else //se non è dentro
                {
                    p.aggiungiControlla(e); //inserisce l'utente nella palestra
                    
                    Persona tmp = p.getAbbonato(p.trovaPosizioneDaNome(e));
                    web.Navigate(tmp.daiLaScheda());
                    MessageBox.Show("benvenuto " + e + " togli il qr e premi ok!"); //blocca l'esecuzione per evitare che legga lo stesso qr più di una volta
                }
            }
            else //se l'utente non è registrato, non può entrare
            {
                MessageBox.Show("UTENTE NON REGISTRATO, PRIMA DI ACCEDERE ALLA PALESTRA!" + "\n" + "BISOGNA REGISTRARSI");
            }

            txt_debug.Text = p.cambiamiIlNome();
            //txt_debug.Text = p.ToString();
            //list.ItemsSource = p.getControlla();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            camSelect.ItemsSource = webCam.CameraNames;
        }

      
    }
}
