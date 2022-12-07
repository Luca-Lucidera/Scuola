using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piu_finestre
{
    public class CConcessionario
    {
        private List<CAuto> v;
        public CConcessionario()
        {
            v = new List<CAuto>();
        }
        public void ADD(CAuto tmp)
        {
            v.Add(tmp);
        }
        public string megaVisTutto()
        {
            string tmp="";
            for(int i = 0; i < v.Count(); i++)
            {
                tmp += v.ElementAt(i).ToString()+"\n";
            }
            return tmp;
        }
        //restituisco la lista presente nella classe
        public List<CAuto> getConcessionario()
        {
            return v;
        }
        public CAuto getElemento(int pos)
        {
            return v.ElementAt(pos);
        }
        public int getNumeroElementi()
        {
            return v.Count();
        }
    }
}
