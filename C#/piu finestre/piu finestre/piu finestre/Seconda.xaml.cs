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
using System.Windows.Shapes;

namespace piu_finestre
{
    /// <summary>
    /// Logica di interazione per Seconda.xaml
    /// </summary>
    public partial class Seconda : Window
    {
        public Seconda()
        {
            InitializeComponent();
        }
        public Seconda(string passaggio)
        {
            InitializeComponent();
            txt2.Text = passaggio;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(txt2.Text);
            m.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            terza t = new terza(txt2.Text);
            t.Show();
            this.Hide();

        }
    }
}
