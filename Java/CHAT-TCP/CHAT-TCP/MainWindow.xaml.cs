using System;
using System.Text;
using System.Windows;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace CHAT_TCP
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpListener listener = null;
        public MainWindow()
        {
            InitializeComponent();
            
            Thread t = new Thread(accettaConnessioniInEntrata);
            t.IsBackground = true;
            t.Start();
        }
        //thread che accetta le connessioni
        public void accettaConnessioniInEntrata()
        {
            listener = new TcpListener(IPAddress.Any, 666);
            listener.Start();
            while (true)
            {
                try
                {
                    TcpClient secondPeer = listener.AcceptTcpClient();
                    Thread threadSecondPeer = new Thread(() => eseguiSecondoPeer(secondPeer, listener));
                    threadSecondPeer.Start();
                }catch (Exception ex)
                {
                    break;
                }               
            }
        }
        //questo viene eseguido da ogni peer che prova a connettersi col peer 1
        private void eseguiSecondoPeer(object o,  object l)
        {
            TcpClient secondPeer = (TcpClient)o;
            TcpListener listener = (TcpListener)l;
            NetworkStream stream = secondPeer.GetStream();
            StreamWriter sw = new StreamWriter(secondPeer.GetStream());
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
                    if (getStringa[0] == 'c')
                    {
                        if (MessageBox.Show("Vuoi connetterti?", "Scossa?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            sw.WriteLine("y;pippo");
                            sw.Flush();
                        }
                        else
                        {
                            sw.WriteLine("n");
                            sw.Flush();
                        }
                         
                    }
                    else if (getStringa[0] == 'y')
                    {
                        sw.WriteLine("y");
                        sw.Flush();
                        
                        Dispatcher.BeginInvoke((Action)(() =>
                        {
                           secondPeer.Close();
                            Messaggi m = new Messaggi(secondPeer,listener);
                            m.Show();
                            Hide();

                        }));
                        break;
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string ip = textBox.Text;
                //ip è del secondo peer
                TcpClient c = new TcpClient(ip, 666);
                
                //invio la C
                string messaggio = "c";
                int ByteCount = Encoding.ASCII.GetByteCount(messaggio + 1);
                byte[] dataBuffer = new byte[ByteCount];
                dataBuffer = Encoding.ASCII.GetBytes(messaggio);
                NetworkStream stream = c.GetStream();
                stream.Write(dataBuffer, 0, dataBuffer.Length);

                //ricevo o Y o N
                StreamReader sr = new StreamReader(stream);
                string risposta = sr.ReadLine();
                //MessageBox.Show(risposta);
                if (risposta[0] == 'y')
                {
                    messaggio = "y";
                    ByteCount = Encoding.ASCII.GetByteCount(messaggio + 1);
                    dataBuffer = new byte[ByteCount];
                    dataBuffer = Encoding.ASCII.GetBytes(messaggio);
                    stream = c.GetStream();
                    stream.Write(dataBuffer, 0, dataBuffer.Length);

                    sr = new StreamReader(stream);
                    risposta = sr.ReadLine();

                    if (risposta[0] == 'y')
                    {
                        listener.Stop();
                        Dispatcher.BeginInvoke((Action)(() =>
                        {
                            c.Close();
                            Messaggi m = new Messaggi(c); //c rappresenta la connessione con il secondo peer (l'indirizzo ip all'interno è del secondo peer)
                            Hide();
                            m.Show();
                        }));
                    }
                }
                else
                {
                    MessageBox.Show("L'altro peer è amogus");
                }
                stream.Close();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
