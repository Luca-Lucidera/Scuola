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

namespace QR_PALESTRA
{
    /// <summary>
    /// Logica di interazione per finestra_scheda.xaml
    /// </summary>
    public partial class finestra_scheda : Window
    {
        Persona p;
        Palestra pa;
        public finestra_scheda()
        {
            InitializeComponent();

        }
        public finestra_scheda(Persona tmp, Palestra tmp2)
        {
            InitializeComponent();
            pa = tmp2;
            rbn_2.IsEnabled = true;
            rbn_3.IsEnabled = true;
            p = tmp;
            combo.Items.Add("MASSA MUSCOLARE");
            combo.Items.Add("FORZA");
            combo.Items.Add("DEFINIZIONE");
            combo.Items.Add("TONIFICAZIONE CORPO");
            combo_livello.Items.Add("PRINCIPIANTE");
            combo_livello.Items.Add("INTERMEDIO");
            combo_livello.Items.Add("ESPERTO");            
        }

        private void btn_genera_Click(object sender, RoutedEventArgs e)
        {
            float tipoScheda = 0;
            if (combo.SelectedIndex == 0) //"massa muscolare
            {
                if (rbn_2.IsChecked == true)
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 0.20F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 0.21F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 0.22F;
                    }
                }
                else
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 0.30F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 0.31F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 0.32F;
                    }
                }
                p.setScheda(tipoScheda);
                pa.aggiungiAbbonato(p);
                finestra_abbonati f = new finestra_abbonati(pa);
                f.Show();
                this.Hide();
            }
            else if (combo.SelectedIndex == 1)
            {
                if (rbn_2.IsChecked == true)
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 1.20F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 1.21F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 1.22F;
                    }
                }
                else
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 1.30F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 1.31F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 1.32F;
                    }
                }
                p.setScheda(tipoScheda);
                pa.aggiungiAbbonato(p);
                finestra_abbonati f = new finestra_abbonati(pa);
                f.Show();
                this.Hide();
            }
            else if (combo.SelectedIndex == 2)
            {
                if (rbn_2.IsChecked == true)
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 2.20F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 2.21F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 2.22F;
                    }
                }
                else
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 2.30F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 2.31F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 2.32F;
                    }
                }
                p.setScheda(tipoScheda);
                pa.aggiungiAbbonato(p);
                finestra_abbonati f = new finestra_abbonati(pa);
                f.Show();
                this.Hide();
            }
            else if (combo.SelectedIndex == 3)
            {
                if (rbn_2.IsChecked == true)
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 3.20F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 3.21F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 3.22F;
                    }
                }
                else
                {
                    if (combo_livello.SelectedIndex == 0)
                    {
                        tipoScheda = 3.30F;
                    }
                    else if (combo_livello.SelectedIndex == 1)
                    {
                        tipoScheda = 3.31F;
                    }
                    else if (combo_livello.SelectedIndex == 2)
                    {
                        tipoScheda = 3.32F;
                    }
                }
                p.setScheda(tipoScheda);
                pa.aggiungiAbbonato(p);
                finestra_abbonati f = new finestra_abbonati(pa);
                f.Show();
                this.Hide();
            }
        }
    }
}
