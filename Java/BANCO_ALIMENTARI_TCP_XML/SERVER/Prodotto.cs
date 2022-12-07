using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public class Prodotto
    {
        public string nome { set; get; }
        public float prezzo { set; get; }
        public Prodotto(){}
        public Prodotto(string nome, float prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }

        public float calcolaPrezzo()
        {
            return prezzo;
        }
    }
}
