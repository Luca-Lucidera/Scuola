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
    /// Logica di interazione per Elimina.xaml
    /// </summary>
    public partial class Elimina : Window
    {
        Cantina c;
        public Elimina()
        {
            InitializeComponent();
            c = new Cantina();
        }
        public Elimina(List<Vino> v)
        {
            InitializeComponent();
            c = new Cantina();
            c.setLista(v);
        }

        private void btn_elimina_Click(object sender, RoutedEventArgs e)
        {
            if(c.rimuoviDallaLista(Convert.ToInt32(textBox.Text))== -1)
            {
                MessageBox.Show("CODICE NON ESISTENTE");
            }
            else
            {
                MessageBox.Show("BOTTIGLIA ELIMINATA");
            }

        }

        private void btn_tornaIndietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(c.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
