using Microsoft.Win32;
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
    /// Logica di interazione per FinestraInserisci.xaml
    /// </summary>
    public partial class FinestraInserisci : Window
    {
        CLibreria l;
        string percorso;
        public FinestraInserisci()
        {
            InitializeComponent();
        }
        public FinestraInserisci(CLibreria lib)
        {
            InitializeComponent();
            l = lib;
            btnInserisci.IsEnabled = false;
        }

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {

            CLibro tmp = new CLibro();
            bool errore = false;
            try
            {
                tmp = new CLibro(txtISBN.Text, txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtprezzo.Text), percorso);
            }
            catch (System.FormatException h)
            {
                Console.WriteLine("Exception caught: {0}", h);
                MessageBox.Show("codice inserito non valido");
                errore = true;
            }

            if (!errore)
            {
                if (l.cerca(txtISBN.Text))//se trova un isbn uguale non aggiunge alla libreria
                {
                    MessageBox.Show("esiste già un libro con questo codice");
                }
                else
                {
                    l.AggiungiLibro(tmp);//altrimenti aggiunge il libro
                    txtISBN.Text = "";
                    txtAutore.Text = "";
                    txtTitolo.Text = "";
                    txtprezzo.Text = "";

                    percorso = "";
                    img.Source = new BitmapImage();
                    MessageBox.Show("libro inserito");
                    btnInserisci.IsEnabled = false;
                }

            }

        }

        private void btnIndietro_Click(object sender, RoutedEventArgs e)
        {

            MainWindow tmp = new MainWindow(l);
            this.Hide();
            tmp.Show();
        }

        private void btnimmagine_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "image files(*.BMP; *.JPG; *.GIF; *.PNG) | *.BMP; *.JPG; *.GIF; *.PNG";
            if (foto.ShowDialog() == true)
            {
                percorso = foto.FileName;
                img.Source = new BitmapImage(new Uri(percorso));
                btnInserisci.IsEnabled = true;
            }
        }
    }
}
