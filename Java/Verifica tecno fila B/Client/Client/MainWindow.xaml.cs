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

namespace Client
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

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            string messaggio = "invia;" + txt_classe.Text + ";" + txt_istituto.Text;
            sendData(messaggio);
            reciveData();
        }
        private void sendData(string messaggio)
        {
            byte[] data = Encoding.ASCII.GetBytes(messaggio);
            client.Send(data, data.Length, "localhost", 12345);

        }
        private void reciveData()
        {
            IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] dataReceived = client.Receive(ref riceveEP);
            MessageBox.Show(Encoding.ASCII.GetString(dataReceived));
        }

        private void btn_ris_Click(object sender, RoutedEventArgs e)
        {
            sendData("risultati;");
            reciveData();
        }
    }
}
