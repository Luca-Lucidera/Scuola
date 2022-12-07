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

namespace VERIFICA_LUCA_LUCIDERA
{
    /// <summary>
    /// Logica di interazione per visualizza.xaml
    /// </summary>
    public partial class visualizza : Window
    {
        CNegozio n = new CNegozio();
        int pos = -1;
        public visualizza()
        {
            InitializeComponent();
            ComboVis.Items.Add("Airoh");
            ComboVis.Items.Add("AGV");
            ComboVis.Items.Add("Suomy");
            sliderVis.Minimum = 54;
            sliderVis.Maximum = 63;
            sliderPrezzo.Maximum = 999;
        }
        public visualizza(CNegozio tmp)
        {
            InitializeComponent();
            n = tmp;
            ComboVis.Items.Add("Airoh");
            ComboVis.Items.Add("AGV");
            ComboVis.Items.Add("Suomy");
            sliderVis.Minimum = 54;
            sliderVis.Maximum = 63;
            sliderPrezzo.Maximum = 999;
        }

        private void btnAvanti_Click(object sender, RoutedEventArgs e)
        {
            if (pos < n.NumElMagazzino() - 1)
            {
                pos++;
                CCasco tmp = n.tornaCasco(pos);
                ComboVis.Text = tmp.getMarca();
                sliderVis.Value = tmp.getMisura();
                labelVis.Content = tmp.getMisura();
                sliderPrezzo.Value = tmp.getPrezzo();
                string retRadioTmp = tmp.getTipologia();
                if (retRadioTmp == "enduro")
                {
                    radioEnduro.IsChecked = true;
                    radioStradale.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else if (retRadioTmp == "stradale")
                {
                    radioStradale.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else
                {
                    radioCross.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioStradale.IsChecked = false;
                }
                image.Source = new BitmapImage(new Uri(tmp.getImmagine()));
            }
        }

        private void btnInditro_Click(object sender, RoutedEventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                CCasco tmp = n.tornaCasco(pos);
                ComboVis.Text = tmp.getMarca();
                sliderVis.Value = tmp.getMisura();
                sliderPrezzo.Value = tmp.getPrezzo();
                string retRadioTmp = tmp.getTipologia();
                if (retRadioTmp == "enduro")
                {
                    radioEnduro.IsChecked = true;
                    radioStradale.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else if (retRadioTmp == "stradale")
                {
                    radioStradale.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else
                {
                    radioCross.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioStradale.IsChecked = false;
                }
                image.Source = new BitmapImage(new Uri(tmp.getImmagine()));
            }
        }

        private void btnInditroVenduti_Click(object sender, RoutedEventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                CCasco tmp = n.tornaCascoVenduto(pos);
                ComboVis.Text = tmp.getMarca();
                sliderVis.Value = tmp.getMisura();
                sliderPrezzo.Value = tmp.getPrezzo();
                string retRadioTmp = tmp.getTipologia();
                if (retRadioTmp == "enduro")
                {
                    radioEnduro.IsChecked = true;
                    radioStradale.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else if (retRadioTmp == "stradale")
                {
                    radioStradale.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else
                {
                    radioCross.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioStradale.IsChecked = false;
                }
                image.Source = new BitmapImage(new Uri(tmp.getImmagine()));
            }
        }

        private void btnAvantiVenduti_Click(object sender, RoutedEventArgs e)
        {
            if (pos < n.NumElVenduti() - 1)
            {
                pos++;
                CCasco tmp = n.tornaCascoVenduto(pos);
                ComboVis.Text = tmp.getMarca();
                sliderVis.Value = tmp.getMisura();
                sliderPrezzo.Value = tmp.getPrezzo();
                string retRadioTmp = tmp.getTipologia();
                if (retRadioTmp == "enduro")
                {
                    radioEnduro.IsChecked = true;
                    radioStradale.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else if (retRadioTmp == "stradale")
                {
                    radioStradale.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioCross.IsChecked = false;
                }
                else
                {
                    radioCross.IsChecked = true;
                    radioEnduro.IsChecked = false;
                    radioStradale.IsChecked = false;
                }
                image.Source = new BitmapImage(new Uri(tmp.getImmagine()));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            n.vendiCasco(pos);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Hide();
            m.Show();
        }
    }
}
