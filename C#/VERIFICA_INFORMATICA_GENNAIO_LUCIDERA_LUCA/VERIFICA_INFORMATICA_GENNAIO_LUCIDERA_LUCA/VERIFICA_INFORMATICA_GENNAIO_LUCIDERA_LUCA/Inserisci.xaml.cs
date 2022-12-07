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

namespace VERIFICA_INFORMATICA_GENNAIO_LUCIDERA_LUCA
{
    /// <summary>
    /// Logica di interazione per Inserisci.xaml
    /// </summary>
    public partial class Inserisci : Window
    {
        Cantina c;
        string percorsoImmagine;
        public Inserisci()
        {
            InitializeComponent();
            c = new Cantina();
            percorsoImmagine = "";
        }
        public Inserisci(List<Vino> v)
        {
            InitializeComponent();
            c = new Cantina();
            c.setLista(v);
            percorsoImmagine = "";
            cmb.Items.Add("ROSSO");
            cmb.Items.Add("Bianco Fermo");
            cmb.Items.Add("Rosè");
            cmb.Items.Add("Bianco FRIZZANTE");
            txt_casa.Text = "";
            txt_codiceBottiglia.Text = "";
            txt_nome.Text = "";
        }

        private void btn_aggiungi_Click(object sender, RoutedEventArgs e)
        {
            Vino v = new Vino(txt_casa.Text, txt_nome.Text, cmb.Text, percorsoImmagine, Convert.ToInt32(txt_codiceBottiglia.Text));
            c.aggiungiVino(v);
            MessageBox.Show("VINO INSERITO");
            txt_casa.Text = "";
            txt_codiceBottiglia.Text = "";
            txt_nome.Text = "";
            cmb.Text = "";
        }

        private void btn_immagine_Click(object sender, RoutedEventArgs e)
        {
            percorsoImmagine = "";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog()==true)
            {
                percorsoImmagine = file.FileName;
            }
        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(c.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
