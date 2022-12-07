using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace CLIENT
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UdpClient client = new UdpClient();
        Listona l = new Listona();
        public MainWindow()
        {
            InitializeComponent();
            sendData("start;","a;a");
            reciveProdotti();
            comboCassieri.Items.Add("A");
            comboCassieri.Items.Add("B");
            comboCassieri.Items.Add("C");
            comboCassieri.Text = "A";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int index = listProdotti.SelectedIndex;
            Prodotto prodotto = l.getProdottoByIndex(index);
            int quantita = Convert.ToInt32(txt_quantita.Text);
            string all = comboCassieri.Text + ";" + prodotto.toCSV() + ";" + quantita;
            sendData("ordine;",all);
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            sendData("chiudi;", comboCassieri.Text);
            reciveData();
        }
        private void btn_scontrino_Click(object sender, RoutedEventArgs e)
        {
            sendData("scontrino;", comboCassieri.Text);
            reciveData();
        }
        public void sendData(string richiesta, string ordineCSV)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(richiesta+ordineCSV);
            client.Send(buffer, buffer.Length, "localhost", 666);
        }
        public void reciveData(){
            //IPEndPoint object will allow us to read datagrams sent from any source.
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            // Blocks until a message returns on this socket from a remote host.
            Byte[] receiveBytes = client.Receive(ref RemoteIpEndPoint);
            string returnData = Encoding.ASCII.GetString(receiveBytes);
            MessageBox.Show(returnData);
        }
        public void reciveProdotti()
        {
            try
            {
                //IPEndPoint object will allow us to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                // Blocks until a message returns on this socket from a remote host.
                Byte[] receiveBytes = client.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                l.aggiungiProdotto(returnData);
                listProdotti.ItemsSource = l.getList();
            }
            catch (Exception ex)
            {
                string errore = ex.Message;
                errore = "Server offline!";
                MessageBox.Show(errore);
            }
            
        }

    }
}
