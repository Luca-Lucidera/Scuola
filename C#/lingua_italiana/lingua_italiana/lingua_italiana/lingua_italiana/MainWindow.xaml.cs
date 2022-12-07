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

namespace lingua_italiana
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dizionario d;
        public MainWindow()
        {
            InitializeComponent();
            d = new Dizionario();
           
        }

        private void btn_carica_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog apertura = new OpenFileDialog();
            if(apertura.ShowDialog() == true)
            {
                string path = apertura.FileName;
                d.setPercorso(path);
                d.caricaDizionario();
                lst.ItemsSource = d.getLista();
            }
        }

        private void btn_cerca_parola_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(d.cercaParola(txt_cerca.Text));
        }

        private void btn_anagrammi_Click(object sender, RoutedEventArgs e)
        {
            string x = d.cercaAnagramma(txt_cerca.Text);
            MessageBox.Show(x);
           // d.cercaAnagramma(txt_cerca.Text);
        }

        private void btn_anagrammi_brutti_Click(object sender, RoutedEventArgs e)
        {
            string x = d.cercaAnagrammaMaBrutto(txt_cerca.Text);
            MessageBox.Show(x);
        }
    }
}
