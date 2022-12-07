using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalone
{
    class Garage
    {
        private List<Auto> v;
        private int pos; //posizione indice del vettore
        private string nomeFile;
        public Garage()
        {
            this.v = new List<Auto>();
            pos = 0;
            nomeFile = "";
        }
        public void salvaNomeFile(string s)
        {
            nomeFile = s;
        }
        public void aggiungiAuto(Auto x)
        {
            v.Add(x);
            pos++;
        }
        public void eliminaAuto(int x)
        {
            v.RemoveAt(x - 1);
            pos--;
        }
        public int getPos()
        {
            return pos;
        }
        public string megaVisTutto()
        {
            string tmp = "";
            for (int i = 0; i < v.Count(); i++)
            {
                tmp += v.ElementAt(i).visTutto() + "\n";
            }
            return tmp;
        }
        public string visNext()
        {
            
            return "";
        }
        public string getMarca(int pos2)
        {
            if(pos < v.Count())
            {
                return v.ElementAt(pos2-1).getMarca();
            }
            else
            {
                return v.ElementAt(pos2 - 1).getMarca();
            }
            
        }
        public string getTarga(int pos2)
        {
            if (pos < v.Count())
            {
                return v.ElementAt(pos2 - 1).getTarga();
            }
            else
            {
                return v.ElementAt(pos2 - 1).getTarga();
            }

        }
        public string getAnno(int pos2)
        {
            if (pos < v.Count())
            {
                return v.ElementAt(pos2 - 1).getAnno();
            }
            else
            {
                return v.ElementAt(pos2 - 1).getAnno();
            }
        }
        public string getImmagine(int pos2)
        {
            if (pos < v.Count())
            {
                return v.ElementAt(pos2 - 1).getImmagine();
            }
            else
            {
                return v.ElementAt(pos2 - 1).getImmagine();
            }
        }
        public void salva(string tmp)
        {
            if (nomeFile != "")
            {
                System.IO.File.WriteAllText(nomeFile, tmp);
            }
        }
    }
}


//vecchio metodo per adare avanti e indietro
/*   public string visPrev()
           {

               /*if (a > 1)
               {
                   a -= 1;
                   string b = v.ElementAt(a - 1).visTutto();

                   return b;
               }
               else
               {
                   string b = v.ElementAt(a - 1).visTutto();
                   return b;
               }
           }
       */
