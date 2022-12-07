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
    /// Logica di interazione per finestra_cerca_modifica.xaml
    /// </summary>
    public partial class finestra_visualizza : Window
    {
        Biglietteria b;
        public finestra_visualizza()
        {
            InitializeComponent();
        }
        public finestra_visualizza(Biglietteria b)
        {
            InitializeComponent();
            this.b = b;
            lst_biglietti.ItemsSource = b.getBiglietteria();
        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(b);
            this.Hide();
            m.Show();
        }

        private void lst_biglietti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Biglietto tmp = b.getBiglietto(lst_biglietti.SelectedIndex);
            txt_cognome.Text = tmp.getCognome();
            txt_email.Text = tmp.getEmail();
            txt_evento.Text = tmp.getEvento() +" " +tmp.getPosto() + " " + tmp.getPosizione();
            txt_nome.Text = tmp.getNome();
            txt_numeroBiglietto.Text = Convert.ToString(tmp.getNumBiglietto());
            txt_numeroTelefono.Text = Convert.ToString(tmp.getNumTel());
            txt_prezzo.Text = Convert.ToString(tmp.getPrezzo());
            qr.Source = new BitmapImage(new Uri(tmp.getImmagine()));
        }
    }
}
