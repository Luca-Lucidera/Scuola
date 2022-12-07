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
    /// Logica di interazione per finestra_cerca.xaml
    /// </summary>
    public partial class finestra_cerca : Window
    {
        Biglietto biglietto;
        Biglietteria b;
        int posizioneBigliettoTrovato;
        public finestra_cerca()
        {
            InitializeComponent();
        }
        public finestra_cerca(Biglietteria b)
        {
            InitializeComponent();
            this.b = b;
            biglietto = new Biglietto();
            btn_modifica.IsEnabled = false;
            posizioneBigliettoTrovato = - 1;
        }
        private void btn_modifica_Click(object sender, RoutedEventArgs e)
        {
            finestra_modifica f = new finestra_modifica(b,biglietto, posizioneBigliettoTrovato);
            f.Show();
            this.Hide();
        }

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            string da_trovare = txt_trova.Text;
            biglietto = b.trovaBiglietto(da_trovare);
            if(biglietto != null)
            {
                txt_cognome.Text = biglietto.getCognome();
                txt_nome.Text = biglietto.getNome();
                txt_email.Text = biglietto.getEmail();
                txt_evento.Text = biglietto.getEvento();
                txt_numeroBiglietto.Text = Convert.ToString(biglietto.getNumBiglietto());
                txt_numeroTelefono.Text = Convert.ToString(biglietto.getNumTel());
                txt_costo.Text = Convert.ToString(biglietto.getPrezzo());
                btn_modifica.IsEnabled = true;
                posizioneBigliettoTrovato = b.cercaBigliettoTornaPosizione(da_trovare);
            }
            else
            {
                MessageBox.Show("NESSUN BIGLIETTO TROVATO");
                btn_modifica.IsEnabled = false;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(b);
            this.Hide();
            m.Show();
        }
    }
}
