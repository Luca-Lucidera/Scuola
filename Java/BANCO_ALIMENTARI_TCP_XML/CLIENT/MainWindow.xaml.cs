using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using System.Xml.Serialization;

namespace CLIENT
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpClient server = new TcpClient();
        XmlSerializer xml;
        StreamReader sr;
        public MainWindow()
        {
            InitializeComponent();
            sld.Minimum = 1;
            sld.Maximum = 50;
            server.Connect("localhost", 42069);
            sr = new StreamReader(server.GetStream());
            XmlSerializer xml = new XmlSerializer(typeof(Prodotti));
            Prodotti p = (Prodotti)xml.Deserialize(sr);
            for (int i = 0; i < p.prodotti.Count; i++)
            {
                ComboProdotti.Items.Add(p.prodotti.ElementAt(i).nome + " " + p.prodotti.ElementAt(i).prezzo);
            }
        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbl_q.Content = "Quantità: " + sld.Value.ToString("0");
        }

        private void add_ordine_Click(object sender, RoutedEventArgs e)
        {
            Prodotto p = new Prodotto();
            p.FromString(ComboProdotti.Text);
            Messaggio m = new Messaggio("a", Convert.ToInt32(sld.Value.ToString("0")), p);
            xml = new XmlSerializer(typeof(Messaggio));
            TextWriter tw = new StreamWriter(server.GetStream());
            xml.Serialize(tw, m);

            
        }
    }
}
