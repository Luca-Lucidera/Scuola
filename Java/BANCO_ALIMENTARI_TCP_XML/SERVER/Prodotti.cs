using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public class Prodotti
    {
        public List<Prodotto> prodotti = new List<Prodotto>();
        public void addProdotto(Prodotto o) { prodotti.Add(o); }

    }
}
