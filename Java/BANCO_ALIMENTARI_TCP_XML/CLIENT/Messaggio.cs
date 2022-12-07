using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT
{
    public class Messaggio
    {
        string comando { set; get; }
        Prodotto p { set; get; }
        int quantita { set; get; }
        public Messaggio()
        {
            comando = "";
            p = new Prodotto();
        }
        public Messaggio(string m, int q, Prodotto p)
        {
            comando = m;
            this.p = p;
            quantita = q;
        }
    }
}
