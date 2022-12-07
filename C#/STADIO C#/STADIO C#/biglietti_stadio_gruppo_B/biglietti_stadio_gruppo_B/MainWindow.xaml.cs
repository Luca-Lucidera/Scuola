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
using System.Windows.Threading;

namespace biglietti_stadio_gruppo_B
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biglietteria b;
        public MainWindow()
        {
            InitializeComponent();
            b = new Biglietteria();
            DispatcherTimer tempo = new DispatcherTimer();
            //ogni quanto  tempo ripete 
            tempo.Interval = TimeSpan.FromSeconds(1);
            tempo.Tick += tempo_Tick;
            tempo.Start();
        }
        public MainWindow(Biglietteria b)
        {
            InitializeComponent();
            this.b = b;
            DispatcherTimer tempo = new DispatcherTimer();
            //ogni quanto  tempo ripete 
            tempo.Interval = TimeSpan.FromSeconds(1);
            tempo.Tick += tempo_Tick;
            tempo.Start();
        }
        void tempo_Tick(object sender, EventArgs e)
        {
            lbl_orario.Content = DateTime.Now.ToLongTimeString();
        }
        private void btn_Nuovo_biglietto_Click(object sender, RoutedEventArgs e)
        {
            finsetra_nuovoBiglietto f = new finsetra_nuovoBiglietto(b);
            this.Hide();
            f.Show();
        }

        private void btn_visualizza_Click(object sender, RoutedEventArgs e)
        {
            finestra_visualizza f = new finestra_visualizza(b);
            this.Hide();
            f.Show();
        }

        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == true)
            {
                b.setNomeFile(save.FileName);
                b.salvaSuFileCSV();
            }
            
        }

        private void btn_carica_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == true)
            {
                b.setNomeFile(open.FileName);
                b.caricaFile();
            }
        }

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            finestra_cerca f = new finestra_cerca(b);
            f.Show();
            this.Hide();
        }

        private void btn_eventi_Click(object sender, RoutedEventArgs e)
        {
            finestra_eventi f = new finestra_eventi(b);
            this.Hide();
            f.Show();
        }

        private void btn_carica_eventi_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == true)
            {
                b.setPercorsoEventi(o.FileName);
                b.caricaEventi();
            }
            
        }
    }
}
