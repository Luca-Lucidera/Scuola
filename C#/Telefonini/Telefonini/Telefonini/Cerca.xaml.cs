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

namespace Telefonini
{
    /// <summary>
    /// Logica di interazione per Cerca.xaml
    /// </summary>
    public partial class Cerca : Window
    {
        public Cerca()
        {
            InitializeComponent();
        }
        public Cerca(Negozio tmp)
        {
            InitializeComponent();
            Negozio n = tmp; 
        }


    }
}
