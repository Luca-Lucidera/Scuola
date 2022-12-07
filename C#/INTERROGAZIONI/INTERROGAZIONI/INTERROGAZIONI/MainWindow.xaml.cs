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

namespace INTERROGAZIONI
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        interrogazione tmp;
        Interrogazioni i;
        public MainWindow()
        {
            InitializeComponent();
            comboMateria.Items.Add("ITA");
            comboMateria.Items.Add("INFO");
            comboMateria.Items.Add("STORIA");
            comboMateria.Items.Add("MATE");
            for(int i = 1; i <= 10; i++ )//ciclo for per mettere nella comboBox i voti da 1 a 10
            {
                comboVoto.Items.Add(i);
            }
            tmp = new interrogazione();
            i = new Interrogazioni();
        }

        private void btnMemorizza_Click(object sender, RoutedEventArgs e)
        {
            
            tmp = new interrogazione(comboMateria.Text.ToString(), txtData.Text, txtAlunno.Text, Convert.ToInt32(comboVoto.Text));
            MessageBox.Show(tmp.visTutto());
            i.memorizza(tmp);
        }

        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            float x = i.mediaVotiConMateria(Convert.ToString(comboMateria.Text));
            txtDebug.Text = Convert.ToString(x);
        }

        private void btnVisTutto_Click(object sender, RoutedEventArgs e)
        {
            txtDebug.Text = i.megaVisTutto();
        }

        private void btnEliminaInsuf_Click(object sender, RoutedEventArgs e)
        {
            i.eliminaInsuf();
        }

        private void btnEliminaInt0_Click(object sender, RoutedEventArgs e)
        {
            i.eliminaPrima();
        }
    }
}
