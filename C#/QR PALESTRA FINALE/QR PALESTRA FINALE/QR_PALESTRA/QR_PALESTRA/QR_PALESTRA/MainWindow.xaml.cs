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

namespace QR_PALESTRA
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Palestra p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Palestra();
        }
        public MainWindow(Palestra tmp)
        {
            InitializeComponent();
            p = tmp;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            finestra_abbonati f = new finestra_abbonati(p);
            this.Hide();
            f.Show();
        }

        private void btn_salva_txt_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == true)
            {
                p.setPercorsoFile(save.FileName);
                p.salvaTxt();
            }
        }

        private void btn_carica_txt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog carica = new OpenFileDialog();
            if (carica.ShowDialog() == true)
            {
                p.setPercorsoFile(carica.FileName);
                p.carica();
            }
        }

        private void btn_visualizza_Click(object sender, RoutedEventArgs e)
        {
            finesta_visualizza f = new finesta_visualizza(p);
            this.Hide();
            f.Show();
        }
    }
}
