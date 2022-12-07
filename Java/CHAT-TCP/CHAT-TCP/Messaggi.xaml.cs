using System;
using System.Collections.Generic;
using System.IO;
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

namespace CHAT_TCP
{
    /// <summary>
    /// Logica di interazione per Messaggi.xaml
    /// </summary>
    public partial class Messaggi : Window
    {
        TcpClient client = null;
        TcpListener listener = null;
        public Messaggi(TcpClient c)
        {
            InitializeComponent();
            client = c;
            Thread t = new Thread(peer2);
            t.IsBackground = true;
            t.Start();
        }
        public Messaggi(TcpClient c, TcpListener l)
        {
            InitializeComponent();
            client = c;
            listener = l;
            Thread t = new Thread(peer2);
            t.IsBackground = true;
            t.Start();
        }

        public void peer2()
        {
            if (listener == null)
            {
                listener = new TcpListener(IPAddress.Any, 666);
                listener.Start();
            } 
            
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Thread tClient = new Thread(eseguiClient);
                tClient.Start(client);
            }
        }
        private void eseguiClient(object o)
        {
            TcpClient client = (TcpClient)o;
            NetworkStream stream = client.GetStream();
            StreamWriter sw = new StreamWriter(client.GetStream());
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    stream.Read(buffer, 0, buffer.Length);
                    int rec = 0;
                    foreach (byte b in buffer)
                    {
                        if (b != 0)
                        {
                            rec++;
                        }
                    }
                    string getStringa = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

                    /*da qui il peer ricevente deve fare qualcosa*/
                    if(getStringa[0] == 'm')
                    {
                        Dispatcher.BeginInvoke((Action)(() =>
                        {
                            textBlock.Text = getStringa + "\n";
                        }));
                    }
                    else
                    {
                        sw.WriteLine("Comando sconosciuto");
                        sw.Flush();
                    }

                }
                catch (Exception ex)
                {
                    sw.WriteLine(ex.ToString());
                }
            }
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            string messaggio = "mciaocomestai";
            int ByteCount = Encoding.ASCII.GetByteCount(messaggio + 1);
            byte[] dataBuffer = new byte[ByteCount];
            dataBuffer = Encoding.ASCII.GetBytes(messaggio);
            NetworkStream stream = client.GetStream();
            stream.Write(dataBuffer, 0, dataBuffer.Length);
        }
    }
}
