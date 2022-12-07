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

namespace piu_finestre
{
    /// <summary>
    /// Logica di interazione per Dettagli.xaml
    /// </summary>
    public partial class Dettagli : Window
    {
        public Dettagli()
        {
            InitializeComponent();
        }
        public Dettagli(CAuto tmp)
        {
            InitializeComponent();
            lblAnno.Content = tmp.getAnno();
            lblMarca.Content = tmp.getMarca();
            lblModello.Content = tmp.getModello();
            imgAuto.Source = new BitmapImage(new Uri(tmp.getFoto()));
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Hide();
        }
    }
}
