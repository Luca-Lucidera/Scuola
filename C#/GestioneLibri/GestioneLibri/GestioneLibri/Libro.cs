using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibri
{
    public class Libro
    {
        string casa, autore, titolo, isbn,copertina;
        double prezzo;
        public Libro()
        {
            casa = "";
            autore = "";
            titolo = "";
            isbn = "";
            copertina = "";
            prezzo = 0f;
        }

        public Libro(string c, string a, string t, string i, string co, double p)
        {
            casa = c;
            autore = a;
            titolo = t;
            isbn = i;
            copertina = co;
            prezzo = p;
        }
        public string getCasa()
        {
            return casa;
        }
        public string getAutore()
        {
            return autore;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string getIsbn()
        {
            return isbn;
        }
        public string getCopertina()
        {
            return copertina;
        }
        public double getPrezzo()
        {
            return prezzo;
        }
        public override string ToString()
        {
            return titolo + " " + autore + " " + casa + " " + isbn + " " + prezzo;
        }
    }
}
