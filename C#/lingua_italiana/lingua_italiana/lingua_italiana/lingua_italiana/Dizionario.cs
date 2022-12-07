using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lingua_italiana
{
    class Dizionario
    {
        private string percorso;
        private List<string> l;
        public Dizionario()
        {
            percorso = "";
            l = new List<string>();
        }
        public void setPercorso(string percorso)
        {
            this.percorso = percorso;
        }
        public void caricaDizionario()
        {
            l.Clear();
            string tuttoIlFile = File.ReadAllText(percorso);
            string[] divisoInRighe = tuttoIlFile.Split('\n');
            for (int i = 0; i < divisoInRighe.Length; i++)
            {
                l.Add(divisoInRighe[i]);
            }
           /*
            for (int i = 0; i < l.Count; i++)
            {
                if (l.ElementAt(i) == "")
                    l.RemoveAt(i);
            }
            */
        }
        public List<string> getLista()
        {
            return l;
        }
        public string cercaParola(string parola)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if(l.ElementAt(i) == parola)
                {
                    return "parola trovata: " + l.ElementAt(i);
                }
            }
            return "parola inserita non trovata!";
        }
        public string cercaAnagramma(string pa)
        {
            if(pa.Length < 4 && pa.Length > 9)
            {
                return "PAROLA INSERITA TROPPO LUNGA!";
            }
            bool trovata = false;
            int p = 0;
            string parola = "";
            do
            {
                if(pa == l.ElementAt(p))
                {
                    trovata = true;
                    parola = l.ElementAt(p);
                }
                p++;
            } while (trovata == false && p < l.Count); //ho trovato la parola
            if (trovata == false)
                return "errore!";
            // ----------------------------------------------------------------------------
            //faccio il sort della parola
            char[] sortParola = parola.ToCharArray();
            for (int j = 0; j < (sortParola.Length - 1); j++)
                for (int i = 0; i < (sortParola.Length - 1); i++)
                    if (sortParola[i] > sortParola[i + 1])
                        swap(ref sortParola[i],ref sortParola[i + 1]);
            string parolaFinale = "";
            for (int i = 0; i < sortParola.Length; i++) //ritrasformo la parola sortata in un stringa
            {
                parolaFinale += sortParola[i].ToString();
            }
            //-----------------------------------------------------------------------------------
            //cero gli anagrammi:
            //1) cerco in tutta la lista le parole della stessa lunghezza
            //2) quando trovo una parola della stessa lunghezza faccio lo stesso procedimento di prima
            //3) confronto le parole sortate e se uguali, posso aggiungerle a una stringa di ritorno
            string cosoDaRitornare = "";
            for (int i = 0; i < l.Count; i++)
            {
                if(l.ElementAt(i).Length == parola.Length ) //vedo la lunghezzza
                {
                    char[] sortTemporaneo = l.ElementAt(i).ToCharArray();
                    for (int j = 0; j < (sortTemporaneo.Length - 1); j++)
                        for (int h = 0; h < (sortTemporaneo.Length - 1); h++)
                            if (sortTemporaneo[h] > sortTemporaneo[h + 1])
                                swap(ref sortTemporaneo[h], ref sortTemporaneo[h + 1]);
                    string stoFinendoLeIdee = "";
                    for (int z = 0; z < sortTemporaneo.Length; z++)
                    {
                        stoFinendoLeIdee += sortTemporaneo[z].ToString();
                    }
                    if(parolaFinale == stoFinendoLeIdee)
                    {
                        cosoDaRitornare += l.ElementAt(i) + "\n";
                    }
                }
            }
            string tmp = cosoDaRitornare;
            return cosoDaRitornare;
        }
        void swap(ref char x, ref char y)
        {
            char tmp;
            tmp = x;
            x = y;
            y= tmp;
        }
        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < l.Count; i++)
            {
                if(i < l.Count)
                    tmp += l.ElementAt(i) + "\n";
                else
                    tmp += l.ElementAt(i);

            }
            return tmp;
        }
        public string cercaAnagrammaMaBrutto(string p)
        {
            bool trovata = false;
            string parola = "";
            int c = 0;
            do
            {
                if (p == l.ElementAt(c))
                {
                    trovata = true;
                    parola = l.ElementAt(c);
                }
                c++;
            } while (trovata == false && c < l.Count); //ho trovato la parola
            if (trovata == false)
                return "errore!";
            // ----------------------------------------------------------------------------
            //faccio il sort della parola
            char[] sortParola = parola.ToCharArray();
            for (int j = 0; j < (sortParola.Length - 1); j++)
                for (int i = 0; i < (sortParola.Length - 1); i++)
                    if (sortParola[i] > sortParola[i + 1])
                        swap(ref sortParola[i],ref sortParola[i + 1]);
            string parolaFinale = "";
            for (int i = 0; i < sortParola.Length; i++) //ritrasformo la parola sortata in un stringa
            {
                parolaFinale += sortParola[i].ToString();
            }
            //-----------------------------------------------------------------------------------
            //cero gli anagrammi:
            //1) cerco in tutta la lista le parole della stessa lunghezza
            //2) quando trovo una parola della stessa lunghezza faccio lo stesso procedimento di prima
            //3) confronto le parole sortate e se uguali, posso aggiungerle a una stringa di ritorno
            string cosoDaRitornare = "";
            for (int i = 0; i < l.Count; i++)
            {
                if(l.ElementAt(i).Length == parola.Length - 1 ) //vedo la lunghezzza
                {
                    //array di appoggio
                    char[] sortTemporaneo = l.ElementAt(i).ToCharArray();
                    
                    //ciclo per fare il sort della parola trovata
                    for (int j = 0; j < (sortTemporaneo.Length - 1); j++) 
                        for (int h = 0; h < (sortTemporaneo.Length - 1); h++)
                            if (sortTemporaneo[h] > sortTemporaneo[h + 1])
                                swap(ref sortTemporaneo[h], ref sortTemporaneo[h + 1]); //metodo per fare lo swap 
                   
                    //riconverto l'array della parola trovata in una stringa
                    string parolaTrovata = "";
                    for (int l = 0; l < sortTemporaneo.Length; l++)
                    {
                        parolaTrovata += sortTemporaneo[l].ToString();
                    }
                    //parolaFinale  --> parola inserita dall'utente
                    //parolaTrovata --> parola trovata nella lista
                    string appoggio = parolaFinale;
                    //faccio il ciclo dove tolto una letttera dalla variabile: parolaFinale
                    for (int h = 0; h < parolaFinale.Length; h++)
                    {
                        //rimuovo la lettera nella posizione indicata dal questo ciclo
                        appoggio = appoggio.Remove(h, 1);
                        //vado a controllare se la parola dell'utente - 1 lettera è uguale alla parola trovata
                        if(appoggio == parolaTrovata)
                        {
                            cosoDaRitornare += l.ElementAt(i) + "\n";
                        }
                        appoggio = parolaFinale; //resetto la variabile appoggio
                    }
                }
            }
            return cosoDaRitornare;
        }
    }
    
}
