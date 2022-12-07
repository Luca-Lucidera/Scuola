using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tornello
{
    public class Biglietteria
    {
        private List<string> personeEntrate;
        private List<Biglietto> v;

        private List<int> postiErba;
        private List<int> postiPrimoCerchio;
        private List<int> postiSecondoCerchio;
        private List<int> postiTerzoCerchio;

        private List<int> postiErbaSecondoEvento;
        private List<int> postiPrimoCerchioSecondoEvento;
        private List<int> postiSecondoCerchioSecondoEvento;
        private List<int> postiTerzoCerchioSecondoEvento;

        private List<int> postiErbaTerzoEvento;
        private List<int> postiPrimoCerchioTerzoEvento;
        private List<int> postiSecondoCerchioTerzoEvento;
        private List<int> postiTerzoCerchioTerzoEvento;

        private List<Evento> eventi;
        private int nMaxEventi;
        private int inseriti;
        private string percorsoFileEventi;

        private int numeroEvento1;
        private int numeroEvento2;
        private int numeroEvento3;

        private string fileName;
        public Biglietteria()
        {
            fileName = "";
            nMaxEventi = 3;
            inseriti = 0;
            percorsoFileEventi = "";
            v = new List<Biglietto>();
            postiErba = new List<int>();
            postiPrimoCerchio = new List<int>();
            postiSecondoCerchio = new List<int>();
            postiTerzoCerchio = new List<int>();

            postiErbaSecondoEvento = new List<int>();
            postiPrimoCerchioSecondoEvento = new List<int>();
            postiSecondoCerchioSecondoEvento = new List<int>();
            postiTerzoCerchioSecondoEvento = new List<int>();


            postiErbaTerzoEvento = new List<int>();
            postiPrimoCerchioTerzoEvento = new List<int>();
            postiSecondoCerchioTerzoEvento = new List<int>();
            postiTerzoCerchioTerzoEvento = new List<int>();

            fileName = "";

            for (int i = 1; i <= 50; i++)
            {
                postiErba.Add(i);
                postiErbaSecondoEvento.Add(i);
                postiErbaTerzoEvento.Add(i);
            }
            for (int i = 1; i <= 40; i++)
            {
                postiPrimoCerchio.Add(i);
                postiPrimoCerchioSecondoEvento.Add(i);
                postiPrimoCerchioTerzoEvento.Add(i);
            }
            for (int i = 1; i <= 30; i++)
            {
                postiSecondoCerchio.Add(i);
                postiSecondoCerchioSecondoEvento.Add(i);
                postiSecondoCerchioTerzoEvento.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                postiTerzoCerchio.Add(i);
                postiTerzoCerchioSecondoEvento.Add(i);
                postiTerzoCerchioTerzoEvento.Add(i);
            }
            personeEntrate = new List<string>();
            eventi = new List<Evento>();
        }
        public List<int> getListaErba(string evento)
        {

            for (int i = 0; i < eventi.Count; i++)
            {
                if (evento == eventi.ElementAt(i).getNome())
                {
                    if (i == 0)
                    {
                        return postiErba;
                    }
                    else if (i == 1)
                    {
                        return postiErbaSecondoEvento;
                    }
                    else if (i == 2)
                    {
                        return postiErbaTerzoEvento;
                    }
                }
            }
            return null;
        }
        public List<int> getPrimoCerchio(string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if (evento == eventi.ElementAt(i).getNome())
                {
                    if (i == 0)
                    {
                        return postiPrimoCerchio;
                    }
                    else if (i == 1)
                    {
                        return postiPrimoCerchioSecondoEvento;
                    }
                    else if (i == 2)
                    {
                        return postiPrimoCerchioTerzoEvento;
                    }
                }
            }
            return null;
        }
        public List<int> getSecondoCerchio(string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if (evento == eventi.ElementAt(i).getNome())
                {
                    if (i == 0)
                    {
                        return postiSecondoCerchio;
                    }
                    else if (i == 1)
                    {
                        return postiSecondoCerchioSecondoEvento;
                    }
                    else if (i == 2)
                    {
                        return postiSecondoCerchioTerzoEvento;
                    }
                }
            }
            return null;
        }
        public List<int> getTerzoCerchio(string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if (evento == eventi.ElementAt(i).getNome())
                {
                    if (i == 0)
                    {
                        return postiTerzoCerchio;
                    }
                    else if (i == 1)
                    {
                        return postiTerzoCerchioSecondoEvento;
                    }
                    else if (i == 2)
                    {
                        return postiTerzoCerchioTerzoEvento;
                    }
                }
            }
            return null;
        }
        public void RimuoviPosto(int posto, string posizione, string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if (eventi.ElementAt(i).getNome() == evento)
                {
                    if (i == 0)
                    {
                        if (posizione == "ERBA")
                        {
                            postiErba.RemoveAt(posto);
                        }
                        else if (posizione == "1° CERCHIO")
                        {
                            postiPrimoCerchio.RemoveAt(posto);
                        }
                        else if (posizione == "2° CERCHIO")
                        {
                            postiSecondoCerchio.RemoveAt(posto);
                        }
                        else if (posizione == "3° CERCHIO")
                        {
                            postiTerzoCerchio.RemoveAt(posto);
                        }
                    }
                    else if (i == 1)
                    {
                        if (posizione == "ERBA")
                        {
                            postiErbaSecondoEvento.RemoveAt(posto);
                        }
                        else if (posizione == "1° CERCHIO")
                        {
                            postiPrimoCerchioSecondoEvento.RemoveAt(posto);
                        }
                        else if (posizione == "2° CERCHIO")
                        {
                            postiSecondoCerchioSecondoEvento.RemoveAt(posto);
                        }
                        else if (posizione == "3° CERCHIO")
                        {
                            postiTerzoCerchioSecondoEvento.RemoveAt(posto);
                        }
                    }
                    else if (i == 2)
                    {
                        if (posizione == "ERBA")
                        {
                            postiErbaTerzoEvento.RemoveAt(posto);
                        }
                        else if (posizione == "1° CERCHIO")
                        {
                            postiPrimoCerchioTerzoEvento.RemoveAt(posto);
                        }
                        else if (posizione == "2° CERCHIO")
                        {
                            postiSecondoCerchioTerzoEvento.RemoveAt(posto);
                        }
                        else if (posizione == "3° CERCHIO")
                        {
                            postiTerzoCerchioTerzoEvento.RemoveAt(posto);
                        }
                    }
                }
            }
        }
        public int getPostoScelto(int indice, string posizione, string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if (eventi.ElementAt(i).getNome() == evento)
                {
                    if (i == 0)
                    {
                        if (posizione == "ERBA")
                        {
                            return postiErba.ElementAt(indice);
                        }
                        else if (posizione == "1° CERCHIO")
                        {
                            return postiPrimoCerchio.ElementAt(indice);
                        }
                        else if (posizione == "2° CERCHIO")
                        {
                            return postiSecondoCerchio.ElementAt(indice);
                        }
                        else if (posizione == "3° CERCHIO")
                        {
                            return postiTerzoCerchio.ElementAt(indice);
                        }
                    }
                    else if (i == 1)
                    {
                        if (posizione == "ERBA")
                        {
                            return postiErbaSecondoEvento.ElementAt(indice);
                        }
                        else if (posizione == "1° CERCHIO")
                        {
                            return postiPrimoCerchioSecondoEvento.ElementAt(indice);
                        }
                        else if (posizione == "2° CERCHIO")
                        {
                            return postiSecondoCerchioSecondoEvento.ElementAt(indice);
                        }
                        else if (posizione == "3° CERCHIO")
                        {
                            return postiTerzoCerchioSecondoEvento.ElementAt(indice);
                        }
                    }
                    else if (i == 2)
                    {
                        if (posizione == "ERBA")
                        {
                            return postiErbaTerzoEvento.ElementAt(indice);
                        }
                        else if (posizione == "1° CERCHIO")
                        {
                            return postiPrimoCerchioTerzoEvento.ElementAt(indice);
                        }
                        else if (posizione == "2° CERCHIO")
                        {
                            return postiSecondoCerchioTerzoEvento.ElementAt(indice);
                        }
                        else if (posizione == "3° CERCHIO")
                        {
                            return postiTerzoCerchioTerzoEvento.ElementAt(indice);
                        }
                    }
                }
            }
            return -1;
        }
        public int generaNumeroBiglietto(string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if (eventi.ElementAt(i).getNome() == evento)
                {
                    if (i == 0)
                    {
                        return ++numeroEvento1;
                    }
                    else if (i == 1)
                    {
                        return ++numeroEvento2;
                    }
                    else if (i == 2)
                    {
                        return ++numeroEvento3;
                    }
                }
            }
            return -1;
        }
        public void aggiungiBiglietto(Biglietto b)
        {
            v.Add(b);
        }
        public List<Biglietto> getBiglietteria()
        {
            return v;
        }
        public Biglietto getBiglietto(int index)
        {
            return v.ElementAt(index);
        }
        public void setNomeFile(string nome)
        {
            fileName = nome;
        }
        public string getCSVTotale()
        {
            string tmp = "";
            for (int i = 0; i < v.Count; i++)
            {
                if (i < v.Count - 1)
                {
                    tmp += v.ElementAt(i).toCSV() + "\n";
                }
                else
                {
                    tmp += v.ElementAt(i).toCSV();
                }
            }
            return tmp;
        }
        public void salvaSuFileCSV()// s è il contenuto che deve salvare
        {
            string s = getCSVTotale(); //trasformo tutti i biglietti in una string 
            File.WriteAllText(fileName, s);
        }
        public void caricaFile()
        {
            v.Clear(); //svuota lista
            Biglietto pTemp;
            string linea;
            string tutto = File.ReadAllText(fileName);

            string[] linee = tutto.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                linea = linee[i];
                string[] campi = linea.Split(';');
                //                      nome    cognome    email     numTel                       posto                      numBiglietto                 prezzo                 evento   posizione + ";" + immagine;                 
                pTemp = new Biglietto(campi[0], campi[1], campi[2], Convert.ToInt32(campi[3]), Convert.ToInt32(campi[4]), Convert.ToInt32(campi[5]), Convert.ToInt32(campi[6]), campi[7], campi[8]);
                pTemp.setImmagine(campi[9]);
                v.Add(pTemp);
            }
        }
        public string getEvento1()
        {
            return eventi.ElementAt(0).getNome();
        }
        public string getEvento2()
        {
            return eventi.ElementAt(1).getNome();
        }
        public string getEvento3()
        {
            return eventi.ElementAt(2).getNome();
        }
        public Biglietto trovaBiglietto(string da_trovare)
        {
            for (int i = 0; i < v.Count; i++)
            {
                if (da_trovare == (v.ElementAt(i).getEvento() + " " + v.ElementAt(i).getNumBiglietto()))
                {
                    return getBiglietto(i);
                }
            }
            return null;
        }
        public int aggiugniEvento(Evento e)
        {
            if (inseriti < nMaxEventi)
            {
                eventi.Add(e);
                inseriti++;
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public void setPercorsoEventi(string percorsoFile)
        {
                percorsoFileEventi = percorsoFile;
        }
        public void caricaEventi()
        {
            eventi.Clear();
            Evento e;
            string linea;
            string tutto = File.ReadAllText(percorsoFileEventi);
            string[] linee = tutto.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                linea = linee[i];
                string[] campi = linea.Split(';');
                e = new Evento(campi[0], campi[1], Convert.ToInt32(campi[2]));
                eventi.Add(e);
            }
        }
        
        public void salvaSuFileEventi()
        {
            string daScrivere = getCSVTotaleEventi();
            File.WriteAllText(percorsoFileEventi, daScrivere);
        }
        public int getLunghezza()
        {
            return eventi.Count;
        }
        public string getEventiDaPosizione(int pos)
        {
            return eventi.ElementAt(pos).getNome();
        }
        public string getCSVTotaleEventi()
        {
            string tmp = "";
            for (int i = 0; i < eventi.Count; i++)
            {
                if (i < eventi.Count - 1)
                {
                    tmp += eventi.ElementAt(i).toCSV() + "\n";
                }
                else
                {
                    tmp += eventi.ElementAt(i).toCSV();
                }
            }
            return tmp;
        }
        public int getPrezzoEvento(string evento)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                if(eventi.ElementAt(i).getNome() == evento)
                {
                    return eventi.ElementAt(i).getPrezzo();
                }
            }
            return -1;
        }
        public int qrEsistente(string e,string evento)
        {
            
            for (int i = 0; i < v.Count; i++)
            {
                if(v.ElementAt(i).getEvento() == evento)
                {
                    string s = v.ElementAt(i).getNome() + " " + v.ElementAt(i).getCognome() + " " + v.ElementAt(i).getEvento();
                    if (s == e)
                    {
                        return 1;
                    }
                }
                
            }
            return -1;
        }
        public bool giaPresente(string e)
        {
            for (int i = 0; i < personeEntrate.Count; i++)
            {
                if(personeEntrate.ElementAt(i) == e)
                {
                    arrivederci(i);
                    return true;
                }
            }
            return false;
        }
        public void aggiungiPersonaEntrata(string e)
        {
            personeEntrate.Add(e);
        }
        public void arrivederci(int index)
        {
            personeEntrate.RemoveAt(index);
        }
        public string visPerosnePresenti()
        {
            string s = "";
            for (int i = 0; i <personeEntrate.Count; i++)
            {
                s += personeEntrate.ElementAt(i) +  "\n";
            }
            return s;
        }
        public void rimuoviTutti()
        {
            personeEntrate.Clear();
        }
    }
}
