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
using System.Collections;


namespace Coda_e_pila_di_nomi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue coda = new Queue();
        Stack pila = new Stack();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMemorizza_Click(object sender, RoutedEventArgs e)
        {
            coda.Enqueue(txtMemorizza.Text);
        }

        private void btnNumeroElementi_Click(object sender, RoutedEventArgs e)
        {
            lblNumeroElementi.Content = coda.Count;
        }

        private void btnElimina_Click(object sender, RoutedEventArgs e) 
        {
            //elimino l'ultimo elemento
            Queue tmp = new Queue(); //creo una coda temporanea
            for (int i = 0; i < coda.Count; i++) //scorro tutta la coda
            {
                object v; //ogetto temporaneo
                v = coda.Dequeue(); //tolgo il primo elemento che trovo
                tmp.Enqueue(v); //e poi lo aggiungo alla lista temporanea
            } //dopo aver visto tutto la coda la pulisco da tutti gli elementi e poi gli dico che la coda ora deve essere uguale a quella temporanea che conterrà tutti gli elementi della prima tranne l'ultimo elemento
            coda.Clear();
            coda = tmp;
        }

        private void btnVis_Click(object sender, RoutedEventArgs e)
        {
            lblVisTutto.Content = "";
            foreach (object valori in coda)
            {
                lblVisTutto.Content += valori + "\n";
            }
        }

        private void btnMemPila_Click(object sender, RoutedEventArgs e)
        {
            pila.Push(txtMemorizza.Text);
        }

        private void btnNElPila_Click(object sender, RoutedEventArgs e)
        {
            lblNumeroElementi.Content = pila.Count;
        }

        private void btnEliminaPila_Click(object sender, RoutedEventArgs e)
        {
            Stack tmp = new Stack(); //creo una coda temporanea
            for (int i = 0; i < pila.Count; i++) //scorro tutta la coda
            {
                object v; //ogetto temporaneo
                v = pila.Pop(); //tolgo il primo elemento che trovo
                tmp.Push(v); //e poi lo aggiungo alla lista temporanea
            } //dopo aver visto tutto la coda la pulisco da tutti gli elementi e poi gli dico che la coda ora deve essere uguale a quella temporanea che conterrà tutti gli elementi della prima tranne l'ultimo elemento
            pila.Clear();
            pila = tmp;
            
        }

        private void btnVisTuttoPila_Click(object sender, RoutedEventArgs e)
        {
            lblVisTutto.Content = "";
            foreach (object val in pila)
            {
                lblVisTutto.Content += val + "\n";
            }
        }
    }
}
