using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preverifica_libri_gennaio
{
    public class CLibreria
    {
        private List<CLibro> v;
        private string percorso;
        public CLibreria()
        {
            v = new List<CLibro>();
        }
        public void setPercorso(string p)
        {
            percorso = p;
        }
        public string getPercorso()
        {
            return percorso;
        }
        public void aggiungiLibro(CLibro tmp)
        {
            v.Add(tmp);
        }
        public List<CLibro> daiLista()
        {
            return v;
        }
        public void setLista(List<CLibro> tmp)
        {
            v = tmp;
        }
        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < v.Count; i++)
            {
                tmp += v.ElementAt(i).ToString() + "\n";
            }
            return tmp;
        }
        public int cercaConIsbn(string isbn)
        {
            
            int i = 0;
            while (i < v.Count)
            {
                if(v.ElementAt(i).getIsbn() == isbn)
                {
                    return i; //ritorno la posione
                }
                i++;
            }
            return -1;
        }
        public string getAutoreByPos(int pos)
        {
            return v.ElementAt(pos).getAutore();
        }
        public string getIsbnByPos(int pos)
        {
            return v.ElementAt(pos).getIsbn();
        }
        public int getPrezzoByPos(int pos)
        {
            return v.ElementAt(pos).getPrezzo();
        }
        public string getTitoloByPos(int pos)
        {
            return v.ElementAt(pos).getTitolo();
        }
        public string getImmagineByPos(int pos)
        {
            return v.ElementAt(pos).getImmagine();
        }
        public void carica()
        {
            v.Clear();
            string tuttoIlFile = File.ReadAllText(percorso);
            string[] linee = tuttoIlFile.Split('\n');
            CLibro tmp = new CLibro();
            for (int i = 0; i < linee.Length; i++)
            {
                string linea = linee[i];
                string[] campi = linea.Split(';');
                tmp = new CLibro(campi[0], campi[1], campi[2], campi[3], Convert.ToInt32(campi[4]));
                v.Add(tmp);
            }
            
        }
        public void salva()
        {
            File.WriteAllText(percorso, getAllCsv());
        }
        public string getAllCsv()
        {
            string tmp = "";
            for (int i = 0; i < v.Count; i++)
            {

                if (i == v.Count - 1)
                {
                    tmp += v.ElementAt(i).toCsv();
                }
                else
                {
                    tmp += v.ElementAt(i).toCsv() + "\n";
                }
            }
            return tmp;
        }
    }
}
