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
    /// Logica di interazione per terza.xaml
    /// </summary>
    public partial class terza : Window
    {
        public terza()
        {
            InitializeComponent();
        }
        public terza(string p)
        {
            InitializeComponent();
            txt3.Text = p;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Seconda s = new Seconda(txt3.Text);
            s.Show();
            this.Hide();
        }
    }
}
