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

namespace VERIFICA_LUCA_LUCIDERA
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CCasco c = new CCasco();
        CNegozio n = new CNegozio();
        public MainWindow()
        {
            InitializeComponent();
            cmb.Items.Add("Airoh");
            cmb.Items.Add("AGV");
            cmb.Items.Add("Suomy");
            slr1.Minimum = 54;
            slr1.Maximum = 63;
            sliderPrezzo.Maximum = 999;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
              marca, tipologia  , immagine, misura, prezzo
             */
            c = new CCasco("Airoh", "enduro", "https://angoloarte.altervista.org/IMMAGINI/teoria_colori4.jpg",61,500);
            n.setCasco(c);
            c = new CCasco("AGV", "stradale", "https://lh3.googleusercontent.com/proxy/M1I8vDb5PMDoIzcSEO9Jk87zX-FDVp-j13fuieKwSKh3761d5glipQEPeZaTIAImXJTi7eYn0YgjszYHSMCZJ-4KBfzd--kVVWnR25hZbJEiR7VJcIzhyzPb_9A", 58, 800);
            n.setCasco(c);
            c = new CCasco("Suomy", "cross", "https://i2.wp.com/www.marialuisaleoni.it/wp-content/uploads/2018/09/IL-POTERE-DEI-COLORI-SFERE.jpg?resize=983%2C616&ssl=1", 55, 854);
            n.setCasco(c);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            visualizza v = new visualizza(n);
            this.Hide();
            v.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();

            if (open1.ShowDialog() == true)
            {
                string path = open1.FileName;
                string tipo;
                if (radioEnduro.IsChecked == true)
                {
                    tipo = "enduro";

                }
                else if (radioStradale.IsChecked == true)
                {
                    tipo = "stradale";
                }
                else
                {
                    tipo = "cross";
                }
                c = new CCasco(cmb.Text, tipo, path, Convert.ToInt32(slr1.Value), Convert.ToInt32(sliderPrezzo.Value));
                n.setCasco(c);
            }
            else
            {
                string path = "";
                string tipo;
                if (radioEnduro.IsChecked == true)
                {
                    tipo = "enduro";

                }
                else if (radioStradale.IsChecked == true)
                {
                    tipo = "stradale";
                }
                else
                {
                    tipo = "cross";
                }
                c = new CCasco(cmb.Text, tipo, path, Convert.ToInt32(slr1.Value), Convert.ToInt32(sliderPrezzo.Value));
                n.setCasco(c);
            }

        }
    }
}
