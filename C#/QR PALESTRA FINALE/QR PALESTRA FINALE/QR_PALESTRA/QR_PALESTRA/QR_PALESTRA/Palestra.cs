using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QR_PALESTRA
{
    public class Palestra
    {
        private List<Persona> lista;
        private string percorsoFile;
        public Palestra()
        {
            lista = new List<Persona>();
            percorsoFile = "";
        }
        public List<Persona> getListaPalestra()
        {
            return lista;
        }
        public void aggiungiAbbonato(Persona tmp)
        {
            lista.Add(tmp);
        }
        public Persona getAbbonato(int pos)
        {
            return lista.ElementAt(pos);
        }
        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < lista.Count; i++)
            {
                tmp += lista.ElementAt(i).ToString() + "\n";
            }
            return tmp;
        }
        public void setPercorsoFile(string perc)
        {
            percorsoFile = perc;
        }
        public void salvaTxt()
        {
            File.WriteAllText(percorsoFile, getCsv());
        }
        public string getCsv()
        {
            string tmp="";
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.Count - 1 > i)
                {
                    tmp+=lista.ElementAt(i).toCsv() + "\n";
                }
                else
                {
                    tmp += lista.ElementAt(i).toCsv();
                }
            }
            return tmp;
        }
        public void carica()
        {
            lista.Clear(); //svuota lista
            Persona pTemp;
            string linea;
            string tutto = File.ReadAllText(percorsoFile);

            string[] linee = tutto.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                linea = linee[i]; //6 parametri
                string[] campi = linea.Split(';');
                pTemp = new Persona(campi[0], campi[1], campi[2], campi[3], Convert.ToInt32(campi[4]),campi[5]);
                pTemp.setScheda(float.Parse(campi[6]));
                lista.Add(pTemp);
            }
            
        }
        public string controllaSeEsiste(string e)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                string tmp = lista.ElementAt(i).getNome() + " " + lista.ElementAt(i).getCognome();
                if (tmp == e)
                    return e;
            }
            return "qr inesistente";
        }
    }
}
