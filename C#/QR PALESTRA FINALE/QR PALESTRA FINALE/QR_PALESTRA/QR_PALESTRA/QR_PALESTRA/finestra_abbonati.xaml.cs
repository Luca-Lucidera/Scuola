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
namespace QR_PALESTRA
{
    /// <summary>
    /// Logica di interazione per finestra_abbonati.xaml
    /// </summary>
    public partial class finestra_abbonati : Window
    {
        Palestra p;
        Bitmap qrCodeImage;
        QRCodeGenerator qrGenerator;
        QRCodeData qrCodeData;
        public finestra_abbonati()
        {
            InitializeComponent();
            p = new Palestra();
        }
        public finestra_abbonati(Palestra tmp)
        {
            InitializeComponent();
            p = tmp;
        }
        private void btn_qr_Click(object sender, RoutedEventArgs e)
        {
            string daCodificare = txt_nome.Text + " "  + txt_cognome.Text;

            qrGenerator = new QRCodeGenerator();

            qrCodeData = qrGenerator.CreateQrCode(daCodificare, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);
            SaveFileDialog o = new SaveFileDialog();
            if (o.ShowDialog() == true)
            {
                string percorso = o.FileName;
                qrCodeImage.Save(percorso);
            }
            img_qr.Source = new BitmapImage(new Uri(o.FileName));
            Persona tmp = new Persona(txt_nome.Text, txt_cognome.Text, txt_Inizio_Abbonamento.Text, txt_Fine_Abbonamento.Text, Convert.ToInt32(txt_eta.Text), o.FileName);
            finestra_scheda f = new finestra_scheda(tmp, p);
            this.Hide();
            f.Show();
        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(p);
            this.Hide();
            m.Show();
        }
    }
}
