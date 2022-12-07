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

namespace PrimoProgetto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p1 = new Persona();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //btn1.Content = "E se te ne penti?";
            txt1.Text = p1.presentati();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //gli passo come parametro le scritte conteneti nelle textbox
            p1.setPresona(txtNome.Text, textCognome.Text,Convert.ToInt32(textEta.Text));
        }
    }
}