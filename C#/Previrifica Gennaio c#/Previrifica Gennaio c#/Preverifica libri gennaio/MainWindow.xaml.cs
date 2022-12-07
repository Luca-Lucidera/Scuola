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

namespace Preverifica_libri_gennaio
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CLibreria l;
        public MainWindow()
        {
            InitializeComponent();
            l = new CLibreria();
        }
        public MainWindow(List<CLibro> lista)
        {
            InitializeComponent();
            l = new CLibreria();
            l.setLista(lista);
        }
        private void btn_inserisci_Click(object sender, RoutedEventArgs e)
        {
            Inserisci i = new Inserisci(l.daiLista());
            this.Hide();
            i.Show();
        }
        private void btn_visualizza_Click(object sender, RoutedEventArgs e)
        {
            Visualizza v = new Visualizza(l.daiLista());
            this.Hide();
            v.Show();
        }

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            Cerca c = new Cerca(l.daiLista());
            c.Show();
            this.Hide();
        }

        private void btn_carica_Click(object sender, RoutedEventArgs e)
        {
            Carica c = new Carica(l.daiLista());
            this.Hide();
            c.Show();
        }

        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            Salva s = new Salva(l.daiLista());
            this.Hide();
            s.Show();
        }
    }
}
