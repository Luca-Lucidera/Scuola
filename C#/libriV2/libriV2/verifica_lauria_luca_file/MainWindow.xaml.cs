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

namespace GestioneLibri
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
            CLibro tmp = new CLibro("12345678", "manzoni", "Promessi sposi", 22.5, "https://lh3.googleusercontent.com/proxy/ilYw1E4KsQYVsTn2hrtXHiyGeu8ckKd78yP_vKUPfWOe97oUUo80WFXV3m7bAbOVpwpOdO9ZfGhwHP8V6VlyyZngaivE_X53U95YhPQz6N2OEsqCIcuPiMYxgeg");//percorso
            l.AggiungiLibro(tmp);
            tmp = new CLibro("87654321", "dante", "divina commedia", 44.5, "https://images-na.ssl-images-amazon.com/images/I/31CuA8ouR1L._BO1,204,203,200_.jpg");//perorso
            l.AggiungiLibro(tmp);

        }
        public MainWindow(CLibreria lib)
        {
            InitializeComponent();
            l = lib;
        }
        

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            FinestraInserisci tmp = new FinestraInserisci(l);
            this.Hide();
            tmp.Show();
        }

        private void btnVisualizza_Click(object sender, RoutedEventArgs e)
        {
            FinestraVisualizza tmp = new FinestraVisualizza(l);
            this.Hide();
            tmp.Show();
        }

        private void btnCerca_Click(object sender, RoutedEventArgs e)
        {
            FinestraCerca tmp = new FinestraCerca(l);
            this.Hide();
            tmp.Show();
        }

        private void btnCarica_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog carica = new OpenFileDialog();
            if (carica.ShowDialog() == true)
            {
                l.setNomeFile(carica.FileName);
                l.Carica();
            }
        }

        private void btnSalva_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == true)
            {
                l.setNomeFile(save.FileName);
                l.Salva();
            }
        }

        private void btnSalvaBin_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == true)
            {
                l.setNomeFile(save.FileName);
                l.SalvaBin();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog carica = new OpenFileDialog();
            if (carica.ShowDialog() == true)
            {
                l.setNomeFile(carica.FileName);
                l.CaricaBin();
            }
        }
    }
}
