﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChatPeer
{
    /// <summary>
    /// Logica di interazione per Comunicazione1.xaml
    /// </summary>
    public partial class Comunicazione1 : Window
    {
        string username;
        const int port = 2003;
        string ipDestinatario = "";
        UdpClient receivingClient;
        UdpClient sendingClient;
        Thread receivingThread;
        public Comunicazione1(string username)
        {
            InitializeComponent();
            this.username = username;
            //sendingClient = new UdpClient(ipDestinatario, port);
            receivingClient = new UdpClient(port);
            //thread per ricevere i dati in background => non bloccante
            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
        }

        private void tryConnect_Click(object sender, RoutedEventArgs e)
        {
            sendingClient = new UdpClient(txt_ip.Text, port);
            string toSend = "y;"+username;
            byte[] data = Encoding.ASCII.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }
        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            
            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string message = Encoding.ASCII.GetString(data);
                if (message[0] == 'c')
                {
                    string daRitornare = "y;" + username;
                    sendData(endPoint.Address.ToString(), daRitornare);
                }
                else if (message[0] == 'm')
                {
                    Console.WriteLine(message.Substring(2, message.Length));
                }
                else if (message[0] == 'e')
                {
                    //fa qualcosa per chiudere la connessione

                }
                else if (message[0] == 'y')
                {
                    string daRitornare = "y";
                    sendData(endPoint.Address.ToString(), daRitornare);
                }
            }
        }
        private void MessageReceived(string message)
        {
            MessageBox.Show(message);
        }
        private void sendData(string messaggio)
        {
            sendingClient = new UdpClient(txt_ip.Text, port);
            string toSend = messaggio;
            byte[] data = Encoding.ASCII.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }
        private void sendData(string ip, string messaggio)
        {
            sendingClient = new UdpClient(ip, port);
            string toSend = messaggio;
            byte[] data = Encoding.ASCII.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }
    }
}
