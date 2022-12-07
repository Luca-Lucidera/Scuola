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

namespace GestioneLibri
{
    /// <summary>
    /// Logica di interazione per Visualizza.xaml
    /// </summary>
    public partial class Visualizza : Window
    {
        Libreria l = new Libreria();
        public Visualizza()
        {
            InitializeComponent();
        }
        public Visualizza(Libreria tmp)
        {
            l = tmp;
            InitializeComponent();
            List<Libro> tmp2 = l.getLibreria();
            listView.ItemsSource = tmp2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(l);
            this.Hide();
            m.Show();
        }
    }
}
