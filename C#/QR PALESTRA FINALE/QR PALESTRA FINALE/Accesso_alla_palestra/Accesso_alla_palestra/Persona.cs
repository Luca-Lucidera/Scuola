using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesso_alla_palestra
{
    public class Persona
    {
        private string nome, cognome, inizio_abbonamento, fine_abbonamento, immagine;
        private int eta;
        float tipoScheda;

        public Persona(string nome, string cognome, string inizio_abbonamento, string fine_abbonamento, int eta, string immagine)
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
            return nome + " " + cognome + " " + inizio_abbonamento + " " + fine_abbonamento + " " + eta + " " + tipoScheda;
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
        public string daiLaScheda()
        {
            string daRitornare="";
            if (tipoScheda == 0.20F) //massa muscolare 2 giorni 
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_massa_principiante_2gg.pdf";
            }
            else if (tipoScheda == 0.21F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_massa_intermedio_2gg.pdf";
            }
            else if (tipoScheda == 0.22F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_massa_avanzato_2gg.pdf";
            }
            else if (tipoScheda == 0.30F)  //massa muscolare 3 giorni 
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_massa_principiante_3gg.pdf";
            }
            else if (tipoScheda == 0.31F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_massa_intermedio_3gg.pdf";
            }
            else if (tipoScheda == 0.32F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_massa_avanzato_3gg.pdf";
            }
            else if (tipoScheda == 1.20F) //foza 2 giorni
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_forza_principiante_2gg.pdf";
            }
            else if (tipoScheda == 1.21F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_forza_intermedio_2gg.pdf";
            }
            else if (tipoScheda == 1.22F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_forza_avanzato_2gg.pdf";
            }
            else if (tipoScheda == 1.30F) //foza 3 giorni
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_forza_principiante_3gg.pdf";
            }
            else if (tipoScheda == 1.31F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_forza_intermedio_3gg.pdf";
            }
            else if (tipoScheda == 1.32F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_forza_avanzato_3gg.pdf";
            }
            else if (tipoScheda == 2.20F) //definizione 2 giorni
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_definizione_principiante_2gg.pdf";
            }
            else if (tipoScheda == 2.21F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_definizione_intermedio_2gg.pdf";
            }
            else if (tipoScheda == 2.22F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_definizione_avanzato_2gg.pdf";
            }
            else if (tipoScheda == 2.30F)//definizione 3 giorni
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_definizione_principiante_3gg.pdf";
            }
            else if (tipoScheda == 2.31F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_definizione_intermedio_3gg.pdf";
            }
            else if (tipoScheda == 2.32F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_definizione_avanzato_3gg.pdf";
            }
            else if (tipoScheda == 3.20F) //tonificazione 2 giorni
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_tonificazione_principiante_2gg.pdf";
            }
            else if (tipoScheda == 3.21F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_tonificazione_intermedio_2gg.pdf";
            }
            else if (tipoScheda == 3.22F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_tonificazione_avanzato_2gg.pdf";
            }
            else if (tipoScheda == 3.30F)//tonificazione 3 giorni
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_tonificazione_principiante_3gg.pdf";
            }
            else if (tipoScheda == 3.31F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_tonificazione_intermedio_3gg.pdf";
            }
            else if (tipoScheda == 3.32F)
            {
                daRitornare = "https://fitprime.com:446/wp-content/uploads/2018/03/scheda_tonificazione_avanzato_3gg.pdf";
            }
            return daRitornare;
        }
    }
}