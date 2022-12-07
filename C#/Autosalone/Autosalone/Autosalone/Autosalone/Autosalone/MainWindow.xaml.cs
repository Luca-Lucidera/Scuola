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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Autosalone
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Garage g1 = new Garage();
        OpenFileDialog open1 = new OpenFileDialog();
        int pos = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            //l'ultimo parametro è il percorso che dell'immagine
            Auto tmp = new Auto(txtMarca.Text, txtTarga.Text, txtAnno.Text, open1.FileName);
            //block.Text = a1.visTutto();
            g1.aggiungiAuto(tmp);
            txtAnno.Text = "";
            txtMarca.Text = "";
            txtTarga.Text = "";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            block.Text = g1.megaVisTutto();
        }

        private void btnIndietro_Click(object sender, RoutedEventArgs e)
        {
            if (pos > 1)
            {
                pos--;
                txtMarca.Text = g1.getMarca(pos);
                txtAnno.Text = g1.getAnno(pos);
                txtTarga.Text = g1.getTarga(pos);
                image.Source = new BitmapImage(new Uri(g1.getImmagine(pos)));
            }
        }

        private void btnAvanti_Click(object sender, RoutedEventArgs e)
        {
            if(pos < g1.getPos())
            {
                pos++;
                txtMarca.Text = g1.getMarca(pos);
                txtAnno.Text = g1.getAnno(pos);
                txtTarga.Text = g1.getTarga(pos);
                image.Source = new BitmapImage(new Uri(g1.getImmagine(pos)));
            } 
        }

        private void btn_elimina_Click(object sender, RoutedEventArgs e)
        {
            g1.eliminaAuto(pos);
        }

        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            g1.salvaNomeFile(txt_salva.Text);
            g1.salva(g1.megaVisTutto());
        }

        private void btn_immagine_Click(object sender, RoutedEventArgs e)
        {
            //setto la cartella iniziale
            open1.InitialDirectory = "C:\\Users\\lucid\\Google Drive\\SCREENSHOT ASSETTO CORSA";
            //filtro per le immagini da scegliere 
            open1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF) | *.BMP;*.JPG;*.JPEG;*.GIF | All files(*.*) | *.*";
           //visualizza finestra e se clicclo apri esegue l'if
            if(open1.ShowDialog() == true)
            {
                MessageBox.Show(open1.FileName);
                string filePath = open1.FileName;
                //creo l'immagine bitmap, che gli passo come parametro
                image.Source = new BitmapImage(new Uri(filePath));
            }
        }
    }
}
