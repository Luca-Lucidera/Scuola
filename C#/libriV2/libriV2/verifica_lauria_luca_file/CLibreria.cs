using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibri
{
    public class CLibreria
    {
        private List<CLibro> lista;
        private string nomeFile;

        public CLibreria()
        {
            lista = new List<CLibro>();
        }

        public void AggiungiLibro(CLibro l)
        {
            lista.Add(l);
        }

        public List<CLibro> GetLibri()
        {
            return lista;
        }
        public CLibro GetElemento(int pos)
        {
            return lista.ElementAt(pos);
        }
        public int GetNumEl()
        {
            return lista.Count;
        }
        public void setNomeFile(string nome)
        {
            nomeFile = nome;
        }
        public string GetAllCsv()
        {
            string ret = "";
            for (int i = 0; i < this.GetNumEl(); i++)
            {
                if (i != this.GetNumEl() - 1)
                    ret += lista.ElementAt(i).ToCsv() + "\n";
                else
                    ret += lista.ElementAt(i).ToCsv();
            }
            return ret;
        }
        public void Salva()
        {
            File.WriteAllText(nomeFile, GetAllCsv());
        }
        public void SalvaBin()
        {
            //serialize data
            using (Stream stream = File.Open(nomeFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, GetLibri());
            }
        }
        public void Carica()
        {
            lista.Clear(); //svuota lista
            CLibro pTemp;
            string linea;
            string tutto = File.ReadAllText(nomeFile);

            string[] linee = tutto.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                linea = linee[i];
                string[] campi = linea.Split(';');
                pTemp = new CLibro(campi[0], campi[1], campi[2], Convert.ToDouble(campi[3]), campi[4]);
                lista.Add(pTemp);
            }
        }
        public void CaricaBin()
        {
            lista.Clear(); //svuota lista
            //deserialize
            using (Stream stream = File.Open(nomeFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                List<CLibro> listaletta = (List<CLibro>)bformatter.Deserialize(stream);
                lista = listaletta;
            }
            

        }
        public bool cerca(string s)
        {
            bool tmp = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.ElementAt(i).getISBN() == s)
                {
                    tmp = true;                    
                }
            }
            return tmp;
        }
        public int cerca_ISBN(string s)//posizione ISBN
        {
            bool tmp = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.ElementAt(i).getISBN() == s)
                {
                    return i;
                }
            }
            return -1;//se -1 non esiste il libro
        }
    }
}

