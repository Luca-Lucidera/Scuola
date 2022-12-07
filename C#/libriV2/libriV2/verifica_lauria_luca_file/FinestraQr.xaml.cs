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

namespace GestioneLibri
{
    /// <summary>
    /// Logica di interazione per FinestraQr.xaml
    /// </summary>
    public partial class FinestraQr : Window
    {
        CLibreria l;
        Bitmap qrCodeImage;
        QRCodeGenerator qrGenerator;
        QRCodeData qrCodeData;
        public FinestraQr()
        {
            InitializeComponent();
        }
        public FinestraQr(CLibreria tmp, CLibro tmp2)
        {
            InitializeComponent();
            l = tmp;
            string daCodificare = tmp2.ToString();

            qrGenerator = new QRCodeGenerator();
            qrCodeData = qrGenerator.CreateQrCode(daCodificare, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);
            //img_qr.Source = BitmapToImageSource(qrCodeImage);
            qrCodeImage.Save(Directory.GetCurrentDirectory()+"\\qr.bmp");
            img_qr.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\qr.bmp"));
        }
        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            FinestraCerca tmp = new FinestraCerca(l);
            tmp.Show();
            this.Hide();
        }
    }
}
