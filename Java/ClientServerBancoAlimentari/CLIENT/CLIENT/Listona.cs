using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT
{
    internal class Listona
    {
        private List<Prodotto> lista;
        public Listona()
        {
            lista = new List<Prodotto>();
        }
        public void aggiungiProdotto(string s)
        {
            string linea = "";
            string[] linee = s.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                linea = linee[i];
                if(linea != "")
                {
                    string[] campi = linea.Split(';');
                    Prodotto prodotto = new Prodotto();
                    prodotto.tipo = campi[0];
                    prodotto.prezzo = campi[1];
                    lista.Add(prodotto);
                }
            }
        }
        public List<Prodotto> getList()
        {
            return lista;
        }
        override
        public string ToString()
        {
            string s = "";
            foreach (Prodotto prodotto in lista)
            {
                s+=prodotto.ToString() + "\n";
            }
            return s;
        }
        public Prodotto getProdottoByIndex(int index)
        {
            return lista.ElementAt(index);
        }
    }
    
}
