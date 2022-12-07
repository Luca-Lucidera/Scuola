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

namespace QR_PALESTRA
{
    /// <summary>
    /// Logica di interazione per finesta_visualizza.xaml
    /// </summary>
    public partial class finesta_visualizza : Window
    {
        Palestra p;
        public finesta_visualizza()
        {
            InitializeComponent();
            p = new Palestra();
        }
        public finesta_visualizza(Palestra tmp)
        {
            InitializeComponent();
            p = tmp;
            lst.ItemsSource = p.getListaPalestra();
        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lst.SelectedIndex;
            Persona tmp = p.getAbbonato(index);
            txt_nome.Text = tmp.getNome();
            txt_cognome.Text = tmp.getCognome();
            txt_Inizio_Abbonamento.Text = tmp.getInizioAbbonamento();
            txt_Fine_Abbonamento.Text = tmp.getFineAbbonamento();
            txt_eta.Text = Convert.ToString(tmp.getEta());
            txt_scheda.Text = Convert.ToString(tmp.getScheda());
            img.Source = new BitmapImage(new Uri(tmp.getImmagine()));

        }

        private void btn_go_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(p);
            this.Hide();
            m.Show();
        }
    }
}
