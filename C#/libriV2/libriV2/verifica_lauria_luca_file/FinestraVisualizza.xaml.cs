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
    /// Logica di interazione per FinestraVisualizza.xaml
    /// </summary>
    public partial class FinestraVisualizza : Window
    {
        CLibreria l;
        public FinestraVisualizza()
        {
            InitializeComponent();
        }
        public FinestraVisualizza(CLibreria lib )
        {
            InitializeComponent();
            l = lib;
            listView.ItemsSource = l.GetLibri();

        }

        private void btnIndietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow(l);
            this.Hide();
            tmp.Show();
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(l.GetElemento(listView.SelectedIndex).getPercorso()));
        }
    }
}
