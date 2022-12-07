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

namespace Preverifica_libri_gennaio
{
    /// <summary>
    /// Logica di interazione per Cerca.xaml
    /// </summary>
    public partial class Cerca : Window
    {
        CLibreria l;
        public Cerca()
        {
            InitializeComponent();
            l = new CLibreria();
        }
        public Cerca(List<CLibro> tmp)
        {
            InitializeComponent();
            l = new CLibreria();
            l.setLista(tmp);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            int pos = l.cercaConIsbn(txtRicerca.Text);
            if (pos != -1)
            {
                txt_Autore.Text = l.getAutoreByPos(pos);
                txt_Isbn.Text = l.getIsbnByPos(pos);
                txt_Prezzo.Text = Convert.ToString(l.getPrezzoByPos(pos));
                txt_Titolo.Text = l.getTitoloByPos(pos);
                image.Source = new BitmapImage(new Uri(l.getImmagineByPos(pos)));
            }
            else
            {
                MessageBox.Show("ISBN NON ESISTENTE!");
            }
                
            
        }

        private void btn_indietro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(l.daiLista());
            this.Hide();
            m.Show();
        }
    }
}
