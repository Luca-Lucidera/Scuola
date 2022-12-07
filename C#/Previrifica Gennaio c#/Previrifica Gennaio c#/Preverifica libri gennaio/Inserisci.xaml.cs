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

namespace Preverifica_libri_gennaio
{
    /// <summary>
    /// Logica di interazione per Inserisci.xaml
    /// </summary>
    public partial class Inserisci : Window
    {
        CLibro tmp;
        CLibreria l;
        OpenFileDialog file;
        string percorso;
        public Inserisci()
        {
            InitializeComponent();
            tmp = new CLibro();
            l = new CLibreria();
            file = new OpenFileDialog();
            percorso = "";
        }
        public Inserisci(List<CLibro> lista)
        {
            InitializeComponent();
            l = new CLibreria();
            file = new OpenFileDialog();
            percorso = "";
            l.setLista(lista);
        }

        private void btn_Immagine_Click(object sender, RoutedEventArgs e)
        {
            if(file.ShowDialog() == true)
            {
                percorso = file.FileName;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tmp = new CLibro(txt_Isbn.Text, txt_Autore.Text, txt_Titolo.Text, percorso, Convert.ToInt32(txt_Prezzo.Text));
            l.aggiungiLibro(tmp);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(l.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
