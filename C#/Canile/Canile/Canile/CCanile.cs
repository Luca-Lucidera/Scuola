using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canile
{
    class CCanile
    {
        private List<Cane> v;
        public CCanile()
        {
            this.v = new List<Cane>();
        }
        public void add(Cane tmp)
        {

            int x=0;
            if(v.Count() == 0)
            {
                v.Add(tmp);
            }
            else
            {
                for (int i = 0; i < v.Count(); i++)
                {
                    if (v.ElementAt(i).getIdChip() == tmp.getIdChip())
                        x++;
                }
                if(x < 1)
                {
                    v.Add(tmp);
                }
            }
        }
        public void remove(int tmp)
        {
            v.RemoveAt(tmp);
        }
        public int ricercaIdChip(string tmp)//tmp sarebbe il chip passato per parametro
        {
            for(int i = 0; i < v.Count(); i++)
            {
                if (v.ElementAt(i).getIdChip() == tmp)
                    return i; //ritorno la posizone nella lista di dove si trova il cane
            }
            return -1;
        }
        public string megaVisTutto()
        {
            string tmp="";
            for(int i = 0; i < v.Count(); i++)
            {
                tmp += v.ElementAt(i).visTutto() + "\n"; 
            }
            return tmp;
        }
        public string getNomeByPos(int pos)
        {
            return v.ElementAt(pos ).getNome();
        }
        public string getChipByPos(int pos)
        {
            return v.ElementAt(pos ).getIdChip();
        }
        public string getRazzaByPos(int pos)
        {
            return v.ElementAt(pos).getRazza();
        }
        public string getProvByPos(int pos)
        {
            return v.ElementAt(pos).getProv();
        }
        public int getPesoByPos(int pos)
        {
            //return Convert.ToInt32((v.ElementAt(pos).getPeso()));
            //provato anche con Int32.Parse((v.ElementAt(pos).getPeso()); ma non funziona
            return 0;
        }
        public bool getSessoByPos(int pos)
        {
            return v.ElementAt(pos ).getSesso();
        }
        public bool getVaccinoByPos(int pos)
        {
            return v.ElementAt(pos).getVaccino();
        }
        public string getImmagineByPos(int pos)
        {
            return v.ElementAt(pos).getImmagine();
        }
    }
}
