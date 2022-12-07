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

namespace VERIFICA_INFORMATICA_GENNAIO_LUCIDERA_LUCA
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cantina c;
        public MainWindow()
        {
            InitializeComponent();
            c = new Cantina();
        }
        public MainWindow(List<Vino> v)
        {
            InitializeComponent();
            c = new Cantina();
            c.setLista(v);
        }

        private void btn_inserisci_Click(object sender, RoutedEventArgs e)
        {
            Inserisci i = new Inserisci(c.daiLista());
            this.Hide();
            i.Show();
        }

        private void btn_visualizza_Click(object sender, RoutedEventArgs e)
        {
            Visualizza v = new Visualizza(c.daiLista());
            this.Hide();
            v.Show();
        }

        private void btn_elimina_Click(object sender, RoutedEventArgs e)
        {
            Elimina el = new Elimina(c.daiLista());
            this.Hide();
            el.Show();
        }

        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog salva = new SaveFileDialog();
            if (salva.ShowDialog() == true)
            {
                c.setPercorosFile(salva.FileName);
                c.save();
            }
        }

        private void btn_carica_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == true)
            {
                c.setPercorosFile(file.FileName);
                c.carica();
            }
        }
    }
}
