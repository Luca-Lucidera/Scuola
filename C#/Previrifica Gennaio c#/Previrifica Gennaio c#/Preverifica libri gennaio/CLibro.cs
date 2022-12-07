using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preverifica_libri_gennaio
{
    public class CLibro
    {
        private string isbn, autore, titlo, immagineCopertina;
        private int prezzo;
        public CLibro()
        {
            isbn = "";
            autore = "";
            titlo = "";
            immagineCopertina = "";
            prezzo = 0;
        }

        public CLibro(string isbn, string autore, string titlo, string immagineCopertina, int prezzo)
        {
            this.isbn = isbn;
            this.autore = autore;
            this.titlo = titlo;
            this.immagineCopertina = immagineCopertina;
            this.prezzo = prezzo;
        }
        public string getIsbn()
        {
            return isbn;
        }
        public string getAutore()
        {
            return autore;
        }
        public string getTitolo()
        {
            return titlo;
        }
        public string getImmagine()
        {
            return immagineCopertina;
        }
        public int getPrezzo()
        {
            return prezzo;
        }
        public override string ToString()
        {
            return isbn + " " + autore + " " + titlo + " " + prezzo;
        }
        public string toCsv()
        {
            return isbn + ";" + autore + ";" + titlo + ";" + immagineCopertina + ";" + prezzo;
        }
    }
}
