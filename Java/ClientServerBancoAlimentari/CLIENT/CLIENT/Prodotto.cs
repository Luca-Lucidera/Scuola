using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT
{
    internal class Prodotto
    {
        //public string cassiere { get; set; }
        public string tipo { get; set; }
        public string prezzo { get; set; }
        override
        public string ToString()
        {
            return tipo + " " + prezzo+"€";
        }
        public string toCSV()
        {
            return tipo+";"+prezzo;
        }
    }
}
