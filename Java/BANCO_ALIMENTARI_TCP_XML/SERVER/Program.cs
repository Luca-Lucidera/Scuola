using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace SERVER
{
    class Program
    {
        static void Main(string[] args)
        {
               
            XmlSerializer xml = new XmlSerializer(typeof(Prodotti));
            StreamReader sr = new StreamReader("prodotti.xml");
            Prodotti p = (Prodotti)xml.Deserialize(sr);
            sr.Dispose();
            sr.Close();

            TcpListener listener = new TcpListener(IPAddress.Any, 42069);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
            TextWriter tw = new StreamWriter(client.GetStream());
            TextReader tr = new StreamReader(client.GetStream());

            xml.Serialize(tw, p);
            tw.Close();
            while (true)
            {
                //aspetto che il client mi invii lo scontrino completo
                Scontrino o = (Scontrino) xml.Deserialize(tr);
                float totale = o.CalcolaTotale();
                xml = new XmlSerializer(typeof(Messaggio));
                tw = new StreamWriter(client.GetStream());
                Messaggio ris = new Messaggio("ok");
                xml.Serialize(tw, ris);
                TextWriter t = new StreamWriter("scontrino.xml");
                t.Write(o);

            }
        }
    }
}
