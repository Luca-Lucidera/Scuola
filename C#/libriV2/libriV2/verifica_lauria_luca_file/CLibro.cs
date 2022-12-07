using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibri
{
    [Serializable]
    public class CLibro
    {
        string isbn;
        string autore;
        string titolo;
        double prezzo;
        string percorso;

        public CLibro()
        {
            isbn = "";
            autore = "";
            titolo = "";
            prezzo = 0;
            percorso = "";
        }

        public CLibro(string i, string a, string t, double p, string f)
        {
            isbn = i;
            autore = a;
            titolo = t;
            prezzo = p;
            percorso = f;
        }

        public override string ToString()
        {
            string tmp;
            tmp = isbn + "/" + autore + "/" + titolo + "/" + prezzo.ToString() + "/" + percorso;
            return tmp;
        }

        public string ToCsv()
        {
            string tmp;
            tmp = isbn + ";" + autore + ";" + titolo + ";" + prezzo.ToString() + ";" + percorso;
            return tmp;
        }

        public string getISBN()
        {
            return isbn;
        }

        public string getAutore()
        {
            return autore;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public double getPrezzo()
        {
            return prezzo;
        }

        public string getPercorso()
        {
            return percorso;
        }
    }
}

