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

namespace biglietti_stadio_gruppo_B
{
    /// <summary>
    /// Logica di interazione per finestra_eventi.xaml
    /// </summary>
    public partial class finestra_eventi : Window
    {
        Biglietteria b;
        public finestra_eventi()
        {
            InitializeComponent();
            b = new Biglietteria();
            sl.Minimum = 30;
            sl.Maximum = 100;
        }
        public finestra_eventi(Biglietteria b)
        {
            InitializeComponent();
            this.b = b;
            sl.Minimum = 30;
            sl.Maximum = 100;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Evento x = new Evento(txt_nome.Text, dp.Text, Convert.ToInt32(sl.Value));
            b.aggiugniEvento(x);

        }

        private void btn_go_back_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            string st= "";
            if(s.ShowDialog() == true)
            {
                st = s.FileName;
                b.setPercorsoEventi(st);
                b.salvaSuFileEventi();
            }
            MainWindow m = new MainWindow(b);
            this.Hide();
            m.Show();
        }

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlockPrezzo.Text = Convert.ToString(Convert.ToInt32(sl.Value));
        }
    }
}
