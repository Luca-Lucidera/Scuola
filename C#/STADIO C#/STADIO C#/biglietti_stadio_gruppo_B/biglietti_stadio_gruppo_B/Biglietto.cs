using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biglietti_stadio_gruppo_B
{
    public class Biglietto
    {
        private string nome, cognome, email;
        private int numTel, posto, numBiglietto, prezzo;
        public string immagine,evento, posizione;

        public Biglietto(string nome, string cognome, string email, int numTel, int posto, int numBiglietto, int prezzo, string evento, string posizione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.numTel = numTel;
            this.posto = posto;
            this.numBiglietto = numBiglietto;
            this.prezzo = prezzo;
            this.evento = evento;
            this.posizione = posizione;
        }

        public Biglietto()
        {
            nome = "";
            cognome = "";
            email = "";
            numTel = 0;
            posto = 0;
            numBiglietto = 0;
            immagine = "";
            evento = "";
        }
        //public Biglietto(string nome,string cognome,string email, int numTel, string evento ,int posto, int prezzo, int numeroBiglietto)
       
        public void setNumBiglietto(int n)
        {
            numBiglietto = n;
        }
        public void setPosto(int p)
        {
            posto = p;
        }
        public void setEvento(string evento)
        {
            this.evento = evento;
        }
        public string getNome()
        {
            return nome;
        }
        public string getCognome()
        {
            return cognome;
        }
        public string getEmail()
        {
            return email;
        }
        public int getNumTel()
        {
            return numTel;
        }
        public int getPosto()
        {
            return posto;
        }
        public int getNumBiglietto()
        {
            return numBiglietto;
        }
        public string getImmagine()
        {
            return immagine;
        }
        public string getEvento()
        {
            return evento;
        }
        public override string ToString()
        {
            return nome +" " +cognome + " " + email + " " + numTel + " " + posto + " " + evento + " " + numBiglietto + " " + prezzo + " " + posizione + " " + immagine;
        }
        public  string toCSV()
        {
            return nome + ";" + cognome + ";" + email + ";" + numTel + ";" + posto + ";" + numBiglietto + ";" + prezzo + ";" + evento + ";" + posizione + ";" + immagine;
        }
        public string getPosizione()
        {
            return posizione;
        }
        public int getPrezzo()
        {
            return prezzo;
        }
        public void setImmagine(string percorso)
        {
            immagine = percorso;
        }
        
    }
}
