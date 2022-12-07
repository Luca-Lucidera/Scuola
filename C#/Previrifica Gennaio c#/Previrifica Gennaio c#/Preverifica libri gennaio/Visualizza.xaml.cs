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
    /// Logica di interazione per Visualizza.xaml
    /// </summary>
    public partial class Visualizza : Window
    {
        CLibreria l;
        public Visualizza()
        {
            InitializeComponent();
            l = new CLibreria();
        }
        public Visualizza(List<CLibro> lista)
        {
            InitializeComponent();
            l = new CLibreria();
            l.setLista(lista);
            lst.ItemsSource = l.daiLista();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(l.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
