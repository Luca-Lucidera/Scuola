using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERIFICA_LUCA_LUCIDERA
{
    public class CCasco
    {
        private string marca,tipologia,immagine;
        private int misura,prezzo;
        public CCasco()
        {
            marca = "";
            tipologia = "";
            immagine = "";
            misura = 0;
            prezzo = 0;
        }
        public CCasco(string m,string t,string i,int mis,int pre)
        {
            marca = m;
            tipologia = t;
            immagine = i;
            misura = mis;
            prezzo = pre;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getTipologia()
        {
            return tipologia;
        }
        public string getImmagine()
        {
            return immagine;
        }
        public int getMisura()
        {
            return misura;
        }
        public int getPrezzo()
        {
            return prezzo;
        }
        public string visTutto()
        {
            return "Marca: " + marca + " tipologia: " + tipologia + " misura: " + Convert.ToString(misura) + " prezzo: " + Convert.ToString(prezzo); 
        }
    }
}
