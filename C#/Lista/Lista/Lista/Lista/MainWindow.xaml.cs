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

namespace Lista
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo lista = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lista = null;
            Nodo nuovo;
            for (int k = 0; k < 10; k++)
            {
                nuovo = new Nodo();
                nuovo.info = k;
                nuovo.next = lista;
                lista = nuovo;
            }
            MessageBox.Show("Lista creata...");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "";
            Nodo punta = lista;
            while (punta != null)
            {

                lbl1.Content += punta.info + "\n";
                punta = punta.next;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            int cont = 0;
            Nodo punta = lista;
            while (punta != null)
            {
                cont++;
                punta = punta.next;
            }
            MessageBox.Show("Numero elementi: " + cont);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            // ricerca elemento
            int checosa = Convert.ToInt32(textBox.Text);
            bool trovato = false;
            Nodo punta = lista;
            while (punta != null && !trovato)
            {
                if (punta.info == checosa)
                    trovato = true;
                else
                    punta = punta.next;
            }
            // fuori dal ciclo
            if (trovato)
                MessageBox.Show("PRESENTE");
            else
                MessageBox.Show("ASSENTE");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            // AGGIUNTA IN TESTA
            int checosa = Convert.ToInt32(textBox.Text);
            Nodo nuovo = new Nodo();
            nuovo.info = checosa;
            nuovo.next = lista;
            lista = nuovo;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            int checosa = Convert.ToInt32(textBox.Text);
            Nodo nuovo = new Nodo();
            nuovo.info = checosa;
            nuovo.next = null;
            if (lista == null)
            {
                lista = nuovo;
            }
            else
            {
                Nodo temp;
                temp = lista;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = nuovo;
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int pos;
            pos = Convert.ToInt32(txtPos.Text);
            //num = Convert.ToInt32(txtNum.Text);
            lista.eliminaNodo(pos);
        }
    }
}
