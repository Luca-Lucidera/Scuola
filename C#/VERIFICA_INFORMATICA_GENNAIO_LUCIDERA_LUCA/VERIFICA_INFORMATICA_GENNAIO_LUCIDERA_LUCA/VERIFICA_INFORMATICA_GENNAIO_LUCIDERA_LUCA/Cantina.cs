using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERIFICA_INFORMATICA_GENNAIO_LUCIDERA_LUCA
{
    public class Cantina
    {
        private List<Vino> v;
        private string percorsoFile;
        public Cantina()
        {
            v = new List<Vino>();
            percorsoFile = "";
        }
        public void aggiungiVino(Vino tmp)
        {
            bool possoInserire = false;
            if (v.Count == 0)
            {
                v.Add(tmp);
            }
            else
            {
                for (int i = 0; i < v.Count; i++)
                {
                    if (v.ElementAt(i).getCodice() != tmp.getCodice())
                    {
                        possoInserire = true;
                    }
                    else
                    {
                        possoInserire = false;
                        break; //interrompo il ciclo perché ho torvato già un vino con lo stesso codice e quindi non lo inserisco
                    }
                }
                if (possoInserire)
                {
                    v.Add(tmp);
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < v.Count; i++)
            {
                s += v.ElementAt(i).ToString() + "\n";
            }
            return s;
        }
        public List<Vino> daiLista()
        {
            return v;
        }
        public void setLista(List<Vino> tmp)
        {
            v = tmp;
        }
        public string getImmagineByPos(int pos)
        {
            return v.ElementAt(pos).getImmagine();
        }
        public int rimuoviDallaLista(int codice)
        {
            int successo = -1;
            for (int i = 0; i < v.Count; i++)
            {
                if(v.ElementAt(i).getCodice() == codice)
                {
                    v.RemoveAt(i);
                    successo = 1;
                    break;
                }
            }
            return successo;
        }
        public void setPercorosFile(string tmp)
        {
            percorsoFile = tmp;
        }
        public void save()
        {
            string fileFinitoInCsv="";
            for (int i = 0; i < v.Count; i++)
            {
                if (i == v.Count - 1)
                {
                    fileFinitoInCsv += v.ElementAt(i).toCsv();
                }
                else
                {
                    fileFinitoInCsv += v.ElementAt(i).toCsv() + "\n";
                }
            }
            File.WriteAllText(percorsoFile,fileFinitoInCsv);
        }
        public void carica()
        {
            v.Clear(); //pulisco la lista
            string tutto = File.ReadAllText(percorsoFile); //vado a inserire in una stringa tutto il contenuto del file
            string[] linee = tutto.Split('\n');//vado a separe ogni riga in un vettore, quindi la cella 0 conterrà la prima riga, la 1 conterrà la seconda (etc.)
            Vino tmp = new Vino(); //creo oggetto di tipo vino temporaneo
            for (int i = 0; i < linee.Length; i++)
            {
                string linea = linee[i]; //metto in una stringa il contenuto della singola lina presa dal vettore
                string[] campi = linea.Split(';'); //metto in un altro vettore ogni singolo campo separato dal separatore ;
                //              casa     nome     colore     immagine        codice bottiglia
                tmp = new Vino(campi[0], campi[1], campi[2], campi[3], Convert.ToInt32(campi[4]));
                v.Add(tmp);
            }
        }
    }
}
