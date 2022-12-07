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

namespace VERIFICA_INFORMATICA_GENNAIO_LUCIDERA_LUCA
{
    /// <summary>
    /// Logica di interazione per Visualizza.xaml
    /// </summary>
    public partial class Visualizza : Window
    {
        Cantina c;
        public Visualizza()
        {
            InitializeComponent();
            c = new Cantina();
        }
        public Visualizza(List<Vino> v)
        {
            InitializeComponent();
            c = new Cantina();
            c.setLista(v);
            lst.ItemsSource = c.daiLista();
        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(c.getImmagineByPos(lst.SelectedIndex)));
        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(c.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
