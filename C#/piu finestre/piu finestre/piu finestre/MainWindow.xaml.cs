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

namespace piu_finestre
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CConcessionario c;
        CAuto a1, a2;
        bool pigiato;
        public MainWindow()
        {
            InitializeComponent();
            pigiato = false;
            c = new CConcessionario();
            a1 = new CAuto("Fiat","Panda", "R:\\Download\\FOTO_ARDUINO_LED_BOTTONE.jpg", 1990);
            c.ADD(a1);
            a2 = new CAuto("Fiat","Punto", "R:\\Download\\bo.jpg", 1800);
            c.ADD(a2);
        }
        public MainWindow(string p)
        {
            InitializeComponent();
            txt1.Text = p;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string passaggio = txt1.Text;
            Seconda s = new Seconda(passaggio);
            s.Show();
            this.Hide();
        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Dettagli d = new Dettagli(c.getElemento(lst.SelectedIndex));
            d.Show();
            this.Hide();
            
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            /* metodo più ez
              List<CAuto> tmp = c.getConcessionario();
              lst.ItemsSource = tmp;
            */
            //metodo a modo mio
            if (pigiato != true)
            {
                for (int i = 0; i < c.getNumeroElementi(); i++)
                {
                    lst.Items.Add(c.getElemento(i));
                }
                pigiato = true;
            }
                
                  
           
           
        }
    }
}
