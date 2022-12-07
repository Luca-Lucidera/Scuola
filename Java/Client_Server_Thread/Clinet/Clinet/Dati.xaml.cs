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

namespace Clinet
{
    /// <summary>
    /// Logica di interazione per Dati.xaml
    /// </summary>
    public partial class Dati : Window
    {
        
        public Dati()
        {
            InitializeComponent();
        }
        public Dati(string dati)
        {
            InitializeComponent();
           string[] all = dati.Split(';');
            txt_tm.Text = all[0];
            txt_um.Text = all[1];
            txt_tMin.Text = all[2];
            txt_tMax.Text = all[3];
            txt_nTm.Text = all[4];
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Hide();
        }
    }
}
