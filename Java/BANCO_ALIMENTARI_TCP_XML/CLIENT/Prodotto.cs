using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT
{
    public class Prodotto
    {
        public string nome;
        public float prezzo;
        public Prodotto()
        {

        }
        public Prodotto(string nome, float prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }
        public void FromString(string s)
        {
            string[] tmp = s.Split(' ');
            nome = tmp[0];
            prezzo = float.Parse(tmp[1]);
        }
    }
}
