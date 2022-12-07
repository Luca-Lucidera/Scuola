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
    /// Logica di interazione per Carica.xaml
    /// </summary>
    public partial class Carica : Window
    {
        CLibreria l;
        public Carica()
        {
            InitializeComponent();
            l = new CLibreria();
        }
        public Carica(List<CLibro> lista)
        {
            InitializeComponent(); 
            l = new CLibreria();
            l.setLista(lista);
        }

        private void btn_carica_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == true)
            {
                l.setPercorso(file.FileName);
                l.carica();
            }
        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(l.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
