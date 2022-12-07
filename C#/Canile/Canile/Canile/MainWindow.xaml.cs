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

namespace Canile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cane c;
        CCanile v;
        OpenFileDialog d;
        int pos;
        public MainWindow()
        {
            InitializeComponent();
            c = new Cane();
            v = new CCanile();
            d = new OpenFileDialog();
            pos = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            bool sesso = false;
            if(btnMaschio.IsChecked == true)
            {
                sesso = true;
            }
            bool vac = false;
            if (btnVaccinoVero.IsChecked == true)
            {
                vac = true;
            }
            c = new Cane(txtNome.Text, txtId.Text, txtRazza.Text, comboBoxProvincia.Text, d.FileName, slider.Value.ToString(), sesso, vac);
            v.add(c);
            txtNome.Text = ""; txtId.Text = ""; txtRazza.Text = ""; comboBoxProvincia.Text = "";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            comboBoxProvincia.Items.Add("MI");
            comboBoxProvincia.Items.Add("MB");
            comboBoxProvincia.Items.Add("CO");
            comboBoxProvincia.Items.Add("VA");
            comboBoxProvincia.Items.Add("TO");
        }

        private void btnImmagine_Click(object sender, RoutedEventArgs e)
        {
            d.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (d.ShowDialog() == true)
            {
                string filePath = d.FileName;
                image.Source = new BitmapImage(new Uri(filePath));
            }
        }

        private void btnVis_Click(object sender, RoutedEventArgs e)
        {
            labelRiassunto.Content = v.megaVisTutto();
        }

        private void btnCerca_Click(object sender, RoutedEventArgs e)
        {
            pos = v.ricercaIdChip(txtId.Text);
            if (pos != -1)
            {
                txtNome.Text = v.getNomeByPos(pos);
                txtId.Text = v.getChipByPos(pos);
                txtRazza.Text = v.getRazzaByPos(pos);
                if (v.getVaccinoByPos(pos) == true)
                {
                    btnVaccinoVero.IsChecked = true;
                }
                else btnVaccinoFalso.IsChecked = false;
                if (v.getSessoByPos(pos) == true)
                {
                    btnMaschio.IsChecked = true;
                }
                else btnMaschio.IsChecked = false;
               // slider.Value = v.getPesoByPos(pos);
                comboBoxProvincia.Text = v.getProvByPos(pos);
                image.Source = new BitmapImage(new Uri(v.getImmagineByPos(pos)));
                
            }

         
        }

        private void btnAdotta_Click(object sender, RoutedEventArgs e)
        {
            if (pos != -1)
            {
                v.remove(pos);
            }
        }
    }
}
