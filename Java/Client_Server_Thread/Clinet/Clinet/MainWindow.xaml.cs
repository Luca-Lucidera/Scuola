using System;
using System.Collections.Generic;
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

namespace Clinet
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UdpClient client; 
        public MainWindow()
        {
            InitializeComponent();
            client = new UdpClient();
        }
        public MainWindow(string dati)
        {
            InitializeComponent();
            client = new UdpClient();
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            string all = "salva;"+txt_temperatura.Text+";"+ txt_umi.Text;
            sendData(all);
            MessageBox.Show(reciveData());
        }

        private void btn_analizza_Click(object sender, RoutedEventArgs e)
        {
            sendData("finalizza;");
            Dati dati = new Dati(reciveData());
            this.Hide();
            dati.Show();
        }
        private void sendData(string info)
        {
            byte[] data = Encoding.ASCII.GetBytes(info);
            client.Send(data, data.Length, "localhost", 12345);
        }
        private string reciveData()
        {
            IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] dataReceived = client.Receive(ref riceveEP);
            String risposta = Encoding.ASCII.GetString(dataReceived);
            return risposta;
        }
    }
}
