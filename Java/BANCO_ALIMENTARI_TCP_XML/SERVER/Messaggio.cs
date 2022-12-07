using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public class Messaggio
    {
        string comando { set; get; }
        Prodotto p { set; get; }
        public Messaggio(){}
        public Messaggio(string comando, Prodotto p)
        {
            this.comando = comando;
            this.p = p;
        }
        public Messaggio(string comando)
        {
            this.comando = comando;
        }
    }
}