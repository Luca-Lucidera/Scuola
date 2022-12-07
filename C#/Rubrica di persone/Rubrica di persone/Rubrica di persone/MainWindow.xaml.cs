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

namespace Rubrica_di_persone
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CRubrica r = new CRubrica();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //preno il come e cognome dalle textBox
            CPersona tmp = new CPersona(txtNome.Text, txtCognome.Text);
            r.aggiungiPersona(tmp);
            txtNome.Text = "Eliminami per aggiungere un altro NOME";
            txtCognome.Text = "Eliminami per aggiungere un altro COGNOME";
            //così scrivo nella textBLOCK
            block.Text = r.megaVisTutto(); 
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            r.salva(r.megaVisTutto()); //richiamo il metodo per salvare un txt e gli passo come parametro la stringa del visualizza tutto
            MessageBox.Show("Salvataggio completato!");
        }
    }
}