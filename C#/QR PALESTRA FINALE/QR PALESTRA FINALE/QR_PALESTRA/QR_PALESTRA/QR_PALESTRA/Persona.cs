using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_PALESTRA
{
    public class Persona
    {
        private string nome, cognome, inizio_abbonamento,fine_abbonamento,immagine;
        private int eta;
        float tipoScheda;

        public Persona(string nome, string cognome, string inizio_abbonamento, string fine_abbonamento, int eta,string immagine)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.inizio_abbonamento = inizio_abbonamento;
            this.fine_abbonamento = fine_abbonamento;
            this.eta = eta;
            this.immagine = immagine;
        }
        public string getNome()
        {
            return nome;
        }
        public string getCognome()
        {
            return cognome;
        }
        public string getInizioAbbonamento()
        {
            return inizio_abbonamento;
        }
        public string getFineAbbonamento()
        {
            return fine_abbonamento;
        }
        public string getImmagine()
        {
            return immagine;
        }
        public override string ToString()
        {
            return nome + " " + cognome + " " + inizio_abbonamento + " " + fine_abbonamento + " " + eta +" " + tipoScheda;
        }
        public string toCsv()
        {
            return nome + ";" + cognome + ";" + inizio_abbonamento + ";" + fine_abbonamento + ";" + eta + ";" + immagine + ";" + tipoScheda;
        }
        public int getEta()
        {
            return eta;
        }
        public void setScheda(float scheda)
        {
            tipoScheda = scheda;
        }
        public float getScheda()
        {
            return tipoScheda;
        }

    }
}
