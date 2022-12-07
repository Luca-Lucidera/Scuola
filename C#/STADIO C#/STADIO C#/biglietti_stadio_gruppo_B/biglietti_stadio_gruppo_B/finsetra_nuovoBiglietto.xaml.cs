using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    /// Logica di interazione per finsetra_nuovoBiglietto.xaml
    /// </summary>
    public partial class finsetra_nuovoBiglietto : Window
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
        
        public finsetra_nuovoBiglietto()
        {
            InitializeComponent();
            b = new Biglietteria();
            posizione = "";
            eventoTmp = "";
            comboEvento.Items.Add("");
            comboEvento.Items.Add("");
            comboEvento.Items.Add("");
        }
        public finsetra_nuovoBiglietto(Biglietteria b)
        {
            InitializeComponent();
            this.b = b;
            posizione = "";
            eventoTmp = "";
            b.setNomeFile(@"C:\Users\lucid\Desktop\STADIO C#\STADIO C#\STADIO C#\biglietti_stadio_gruppo_B\eventi.txt");
            //b.caricaEventi();
            for (int i = 0; i < b.getLunghezza(); i++)
            {
                comboEvento.Items.Add(b.getEventiDaPosizione(i));
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

        private void lstPosto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(posizione);
            indice = lstPosto.SelectedIndex;
            btn_confermaPosto.IsEnabled = true;
        }

        private void btn_crea_Click(object sender, RoutedEventArgs e)
        {
            b.RimuoviPosto(indice, posizione, eventoTmp);
            int numero_biglietto = b.generaNumeroBiglietto(eventoTmp);
            //GENERAZIONE QR
            string daCodificare = txt_nome.Text + " " + txt_cognome.Text + " " + eventoTmp;
            qrGenerator = new QRCodeGenerator();
            qrCodeData = qrGenerator.CreateQrCode(daCodificare, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);
            SaveFileDialog o = new SaveFileDialog();
            string percorso="";
            if (o.ShowDialog() == true)
            {
                percorso = o.FileName;
                qrCodeImage.Save(percorso);
            }
            biglietto = new Biglietto(txt_nome.Text, txt_cognome.Text, txt_email.Text,Convert.ToInt32(txt_numeroTelefono.Text),postoFinale,numero_biglietto,prezzo,eventoTmp,posizione);//immagine vuota per ora
            biglietto.setImmagine(percorso);
            b.aggiungiBiglietto(biglietto);
            btn_pdf.IsEnabled = true;
        }

        private void btn_goBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(b);
            m.Show();
            this.Hide();
        }
    
        private void comboEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_erba.IsEnabled = true;
            btn_primoCerchio.IsEnabled = true;
            btn_secondoCerchio.IsEnabled = true;
            btn_terzoCerchio.IsEnabled = true;
            int tmp = comboEvento.SelectedIndex;
            
            if(tmp == 0)
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
            else if(tmp == 1)
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
            else if(tmp == 2)
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

        private void btn_pdf_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if(s.ShowDialog() == true)
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                try
                {
                    PdfWriter.GetInstance(doc,new FileStream(s.FileName,FileMode.Create));
                    doc.Open();
                    doc.Add(new iTextSharp.text.Paragraph(biglietto.ToString()));
                }
                catch
                {
                    MessageBox.Show("errore");
                }
                finally
                {
                    doc.Close();
                }
            }
        }
    }
}
