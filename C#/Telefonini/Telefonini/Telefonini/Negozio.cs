using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telefonini
{
    public class Negozio
    {
        private List<telefono> inVendita;
        private List<telefono> venduti;
        public Negozio()
        {
            inVendita = new List<telefono>();
            venduti = new List<telefono>();
        }
        public void addInVendita(telefono tmp)
        {
            inVendita.Add(tmp);
        }
        public void addVenduti(telefono tmp, int pos)
        {
            inVendita.RemoveAt(pos);
            venduti.Add(tmp);
            /*
             alternativa
             venduti.Add(inVendita.elementAt(pos));
             InVendita.RemoveAt(pos);
             */
        }
        public int ricercaPerSeriale(string tmp) //tmp è il codice seriale
        {
            for (int pos = 0; pos < inVendita.Count(); pos++)
            {
                if (tmp == inVendita.ElementAt(pos).getCodiceSeriale())
                {
                    return pos;
                }
            }
            return -1;
        }
        public string visVenduti()
        {
            string tmp = "";
            for (int i = 0; i < venduti.Count(); i++)
            {
                tmp += venduti.ElementAt(i).visTutto() + "\n";
            }
            return tmp;
        }
        public string visinVendita()
        {
            string tmp = "";
            for (int i = 0; i < inVendita.Count(); i++)
            {
                tmp += inVendita.ElementAt(i).visTutto() + "\n";
            }
            return tmp;
        }
        public string getModelloDaPos(int pos)
        {
            return inVendita.ElementAt(pos).getModello();
        }
        public string getSerialeDaPos(int pos)
        {
            return inVendita.ElementAt(pos).getCodiceSeriale();
        }
        public string getMarcaDaPos(int pos)
        {
            return inVendita.ElementAt(pos).getMarca();
        }
        public bool getReteDaPos(int pos)
        {
            return inVendita.ElementAt(pos).getG4();
        }
        public string getImmagineDaPos(int pos)
        {
            return inVendita.ElementAt(pos).getImmagine();
        }


    }
}
