using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERROGAZIONI
{
    class Interrogazioni
    {
        private List<interrogazione> v;
        public Interrogazioni()
        {
            v = new List<interrogazione>();
        }
        public void memorizza(interrogazione tmp)
        {
            v.Add(tmp);
        }
        public float mediaVotiConMateria(string m)
        {
            int tmp = 0;
            int d = 0;
            for (int i = 0; i < v.Count; i++)
            {
                if(v.ElementAt(i).getMateria() == m)
                {
                    tmp += v.ElementAt(i).getVoto();
                    d++;
                }
                else
                {
                    tmp += 0;
                }
            }
            return tmp/d;
        }
        public void eliminaInsuf()
        {
            for (int i = 0; i < v.Count; i++)
            {

                if (v.ElementAt(i).getVoto() < 6)
                {
                    v.RemoveAt(i);
                }
            }
        }
        public string megaVisTutto()
        {
            string tmp = "";
            for(int i = 0;  i < v.Count(); i++)
            {
                tmp += v.ElementAt(i).visTutto() + "\n";
            }
            return tmp;
        }
        public void eliminaPrima()
        {
            v.RemoveAt(0);
        }
    }
}
