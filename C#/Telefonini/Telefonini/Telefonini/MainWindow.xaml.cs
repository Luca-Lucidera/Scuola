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

namespace Telefonini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        telefono t;
        Negozio n;
        OpenFileDialog img;
        int pos;
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add("Samsung");
            comboBox.Items.Add("Apple");
            comboBox.Items.Add("Hauwei");
            t = new telefono();
            n = new Negozio();
            img = new OpenFileDialog();
            pos = -1;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool g4 = false;
            if (rB4.IsChecked == true)
            {
                g4 = true;
            }
            t = new telefono(comboBox.Text, txtSeriale.Text, txtModello.Text, img.FileName, g4);
            n.addInVendita(t);
        }

        private void btnImmagine_Click(object sender, RoutedEventArgs e)
        {
            if (img.ShowDialog() == true)
            {
                string path = "";
                path = img.FileName;
                image.Source = new BitmapImage(new Uri(path));
            }
        }

        private void btnRicerca_Click(object sender, RoutedEventArgs e)
        {
            Cerca c = new Cerca();
            c.Show();
            this.Hide();
            pos = n.ricercaPerSeriale(txtSeriale.Text);
            if (pos != -1)
            {
                txtModello.Text = n.getModelloDaPos(pos);
                txtSeriale.Text = n.getSerialeDaPos(pos);
                comboBox.Text = n.getMarcaDaPos(pos);
                if (n.getReteDaPos(pos))
                {
                    rB4.IsChecked = true;
                }
                else
                {
                    rB5.IsChecked = true;
                }

                image.Source = new BitmapImage(new Uri(n.getImmagineDaPos(pos)));
            }
        }

        private void btnVis_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = n.visVenduti();
        }

        private void btnVendi_Click(object sender, RoutedEventArgs e)
        {
            if (pos != -1)
            {
                txtModello.Text = n.getModelloDaPos(pos);
                txtSeriale.Text = n.getSerialeDaPos(pos);
                comboBox.Text = n.getMarcaDaPos(pos);
                if (n.getReteDaPos(pos))
                {
                    rB4.IsChecked = true;
                }
                else
                {
                    rB5.IsChecked = true;
                }
                bool g4 = false;
                if (rB4.IsChecked == true)
                {
                    g4 = true;
                }
                telefono tmp = new telefono(comboBox.Text, txtSeriale.Text, txtModello.Text, img.FileName, g4);
                n.addVenduti(tmp, pos);
            }
        }
    }
}
