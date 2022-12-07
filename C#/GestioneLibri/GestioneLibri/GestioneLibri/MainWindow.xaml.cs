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

namespace GestioneLibri
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro x = new Libro();
        Libreria l = new Libreria();
        string path = "";
        public MainWindow()
        {
            InitializeComponent();
            sliderPrezzo.Minimum = 20;
            sliderPrezzo.Maximum = 70;
        }
        public MainWindow(Libreria a)
        {
            InitializeComponent();
            sliderPrezzo.Minimum = 20;
            sliderPrezzo.Maximum = 70;
            l = a;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblValPrezzo.Content = sliderPrezzo.Value;
        }

        private void btnCopertina_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            
            if(x.ShowDialog() == true)
            {
                path = x.FileName;
            }
            img.Source = new BitmapImage(new Uri(path));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //casa, autore, titolo, isbn,copertina
            x = new Libro(txtCasa.Text, txtAutore.Text, txtTitolo.Text, txtIsbn.Text, path, sliderPrezzo.Value);
            l.setLibro(x);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Visualizza v = new Visualizza(l);
            this.Hide();
            v.Show();
            
            
        }
    }
}
