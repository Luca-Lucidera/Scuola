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

namespace GestioneLibri
{
    /// <summary>
    /// Logica di interazione per FinestraCerca.xaml
    /// </summary>
    public partial class FinestraCerca : Window
    {
        CLibreria l;
        CLibro tmp;
        string passaggio;
        public FinestraCerca()
        {
            InitializeComponent();
        }
        public FinestraCerca(CLibreria lib)
        {
            InitializeComponent();
            tmp = new CLibro();
            l = lib;
            btn_qr.IsEnabled = false;
            passaggio = "";
        }

        private void btnIndietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow(l);
            this.Hide();
            tmp.Show();
        }

        private void btncerca_Click(object sender, RoutedEventArgs e)
        {
            string s = txtISBN.Text;

            int pos=l.cerca_ISBN(s);

            if (pos==-1)
            {
                MessageBox.Show("libro non trovato"); 
            }
            else
            {

                 tmp = l.GetElemento((pos));
                txtISBNN.Text= tmp.getISBN();
                txtAutore.Text = tmp.getAutore();
                txtTitolo.Text = tmp.getTitolo();
                txtPrezzo.Text = (tmp.getPrezzo().ToString());
                img.Source = new BitmapImage(new Uri(tmp.getPercorso()));
                //MessageBox.Show("libro trovato"); 
                btn_qr.IsEnabled = true;
                passaggio = tmp.ToString();
            }
          
        }

        private void btn_qr_Click(object sender, RoutedEventArgs e)
        {
            FinestraQr f = new FinestraQr(l,tmp);
            this.Hide();
            f.Show();
        }
    }
}
