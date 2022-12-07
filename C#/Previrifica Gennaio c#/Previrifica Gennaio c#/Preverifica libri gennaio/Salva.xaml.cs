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
    /// Logica di interazione per Salva.xaml
    /// </summary>
    public partial class Salva : Window
    {
        CLibreria l;
        public Salva()
        {
            InitializeComponent();
            l = new CLibreria();
        }
        public Salva(List<CLibro> lisa)
        {
            InitializeComponent();
            l = new CLibreria();
            l.setLista(lisa);
        }

        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog salva = new SaveFileDialog();
            if (salva.ShowDialog() == true)
            {
                string percorsoENome = salva.FileName;
                l.setPercorso(percorsoENome);
                l.salva();
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
