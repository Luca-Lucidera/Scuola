using Microsoft.Win32;
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

namespace Edicola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CQuotidiano q;
        CEdicola ed;
        public MainWindow()
        {
            InitializeComponent();
            q = new CQuotidiano();
            ed = new CEdicola();
        }

        private void btnPDF_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Open1 = new OpenFileDialog();
            Open1.Filter = "PDF files (*.pdf) | *.pdf";
            if(Open1.ShowDialog()==true)
            {
                string percorso = Open1.FileName;
                labelPercorso.Content = percorso;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool tmp = false;
            if(btnSi.IsChecked == true)
            {
                tmp = true;
            }
            //nella label devo per forza mettere il ToString perché di base non è una stringa
            q = new CQuotidiano(txtData.Text, txtData.Text, tmp, labelPercorso.Content.ToString());
            MessageBox.Show("OK");
            ed.inserisci(q);
            labelConta.Content = ed.quantiQuotidiani();

        }
    }
}
