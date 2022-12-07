using Microsoft.Win32;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace biglietti_stadio_gruppo_B
{
    /// <summary>
    /// Logica di interazione per finestra_modifica.xaml
    /// </summary>
    public partial class finestra_modifica : Window
    {
        Biglietteria b;
        Biglietto biglietto;
        Bitmap qrCodeImage;
        QRCodeGenerator qrGenerator;
        QRCodeData qrCodeData;
        string posizione;
        string eventoTmp;
        int indice;
        int postoFinale;
        int prezzo;
        int pos;
        public finestra_modifica()
        {
            InitializeComponent();
        }
        public finestra_modifica(Biglietteria b, Biglietto biglietto, int p)
        {
            InitializeComponent();
            this.b = b;
            this.biglietto = biglietto;
            b.setNomeFile(@"C:\Users\lucid\Desktop\STADIO C#\STADIO C#\STADIO C#\biglietti_stadio_gruppo_B\eventi.txt");
            //b.caricaEventi();
            for (int i = 0; i < b.getLunghezza(); i++)
            {
                comboEvento.Items.Add(b.getEventiDaPosizione(i));
            }
            posizione = "";
            eventoTmp = "";
            indice = 0;
            postoFinale = 0;
            prezzo = 0;
            pos = p;
        }

        private void btn_confermaPosto_Click(object sender, RoutedEventArgs e)
        {
            postoFinale = b.getPostoScelto(indice, posizione, eventoTmp); // indice --> indicice | posizione = erba | 1°cerchio...
            MessageBox.Show("DEBUG POSTO FINALE -> " + postoFinale);
            if (posizione == "ERBA")
            {
                prezzo = b.getPrezzoEvento(eventoTmp) + 50;
                lstPosto.ItemsSource = b.getListaErba(eventoTmp);
            }
            else if (posizione == "1° CERCHIO")
            {
                prezzo = b.getPrezzoEvento(eventoTmp) + 35;
                lstPosto.ItemsSource = b.getPrimoCerchio(eventoTmp);
            }
            else if (posizione == "2° CERCHIO")
            {
                prezzo = b.getPrezzoEvento(eventoTmp) + 30;
                lstPosto.ItemsSource = b.getSecondoCerchio(eventoTmp);
            }
            else if (posizione == "3° CERCHIO")
            {
                prezzo = b.getPrezzoEvento(eventoTmp);
                lstPosto.ItemsSource = b.getTerzoCerchio(eventoTmp);
            }
        }

        private void btn_erba_Click(object sender, RoutedEventArgs e)
        {
            lstPosto.ItemsSource = b.getListaErba(eventoTmp);
            txt_debug.Text = "STAI VISUALIZZANDO L'EVENTO: " + eventoTmp + " ERBA";
            posizione = "ERBA";
        }

        private void btn_primoCerchio_Click(object sender, RoutedEventArgs e)
        {
            lstPosto.ItemsSource = b.getPrimoCerchio(eventoTmp);
            txt_debug.Text = "STAI VISUALIZZANDO L'EVENTO: " + eventoTmp + " 1° CERCHIO";
            posizione = "1° CERCHIO";
        }

        private void btn_secondoCerchio_Click(object sender, RoutedEventArgs e)
        {
            lstPosto.ItemsSource = b.getSecondoCerchio(eventoTmp);
            txt_debug.Text = "STAI VISUALIZZANDO L'EVENTO: " + eventoTmp + " 2° CERCHIO";
            posizione = "2° CERCHIO";
        }

        private void btn_terzoCerchio_Click(object sender, RoutedEventArgs e)
        {
            lstPosto.ItemsSource = b.getTerzoCerchio(eventoTmp);
            txt_debug.Text = "STAI VISUALIZZANDO L'EVENTO: " + eventoTmp + " 3° CERCHIO";
            posizione = "3° CERCHIO";
        }

        private void btn_modifica_Click(object sender, RoutedEventArgs e)
        {
            int postoDaRimettere = biglietto.getPosto();
            string posizione = biglietto.getPosizione();
            string eventoScelto = biglietto.getEvento();
            b.reInserisciUnPosto(posizione, postoDaRimettere, eventoScelto);
            string daCodificare = txt_nome.Text + " " + txt_cognome.Text + " " + eventoTmp;
            qrGenerator = new QRCodeGenerator();
            qrCodeData = qrGenerator.CreateQrCode(daCodificare, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);
            SaveFileDialog o = new SaveFileDialog();
            string percorso = "";
            if (o.ShowDialog() == true)
            {
                percorso = o.FileName;
                qrCodeImage.Save(percorso);
            }
            int nBiglietto = biglietto.getNumBiglietto();
            biglietto = new Biglietto(txt_nome.Text, txt_cognome.Text, txt_email.Text, Convert.ToInt32(txt_numeroTelefono.Text), postoFinale, nBiglietto, prezzo, eventoTmp, posizione);//immagine vuota per ora
            biglietto.setImmagine(percorso);
            b.ModificaBiglietto(biglietto, pos);

        }

        private void btn_go_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(b);
            this.Hide();
            m.Show();
        }

        private void comboEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_erba.IsEnabled = true;
            btn_primoCerchio.IsEnabled = true;
            btn_secondoCerchio.IsEnabled = true;
            btn_terzoCerchio.IsEnabled = true;
            int tmp = comboEvento.SelectedIndex;

            if (tmp == 0)
            {
                eventoTmp = b.getEventiDaPosizione(tmp);
                if (posizione == "ERBA")
                {
                    lstPosto.ItemsSource = b.getListaErba(eventoTmp);
                }
                else if (posizione == "1° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getPrimoCerchio(eventoTmp);
                }
                else if (posizione == "2° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getSecondoCerchio(eventoTmp);
                }
                else if (posizione == "3° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getTerzoCerchio(eventoTmp);

                }
                txt_debug.Text = "STAI VISUALIZZANDO L'EVENTO: " + eventoTmp + " " + posizione;
            }
            else if (tmp == 1)
            {
                eventoTmp = b.getEventiDaPosizione(tmp);
                if (posizione == "ERBA")
                {
                    lstPosto.ItemsSource = b.getListaErba(eventoTmp);
                }
                else if (posizione == "1° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getPrimoCerchio(eventoTmp);
                }
                else if (posizione == "2° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getSecondoCerchio(eventoTmp);
                }
                else if (posizione == "3° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getTerzoCerchio(eventoTmp);
                }
            }
            else if (tmp == 2)
            {
                eventoTmp = b.getEventiDaPosizione(tmp);
                if (posizione == "ERBA")
                {
                    lstPosto.ItemsSource = b.getListaErba(eventoTmp);
                }
                else if (posizione == "1° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getPrimoCerchio(eventoTmp);
                }
                else if (posizione == "2° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getSecondoCerchio(eventoTmp);
                }
                else if (posizione == "3° CERCHIO")
                {
                    lstPosto.ItemsSource = b.getTerzoCerchio(eventoTmp);
                }

            }
        }
        private void lstPosto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indice = lstPosto.SelectedIndex;
            btn_confermaPosto.IsEnabled = true;
        }
    }
}
