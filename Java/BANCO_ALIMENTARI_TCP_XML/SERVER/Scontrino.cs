using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    class Scontrino
    {
        public List<Prodotto> lista_prodotti;

        public Scontrino()
        {
            lista_prodotti = new List<Prodotto>();
        }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            lista_prodotti.Add(prodotto);
        }

        public float CalcolaTotale()
        {
            float totale = 0;
            foreach (var prodotto in lista_prodotti)
            {
                totale += prodotto.calcolaPrezzo();
            }
            return totale;
        }
    }
}
