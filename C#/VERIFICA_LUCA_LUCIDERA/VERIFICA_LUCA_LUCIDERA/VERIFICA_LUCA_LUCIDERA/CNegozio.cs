using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERIFICA_LUCA_LUCIDERA
{
    public class CNegozio
    {
        private List<CCasco> Magazzino;
        private List<CCasco> Venduti;
        public CNegozio()
        {
            Magazzino = new List<CCasco>();
            Venduti = new List<CCasco>();
        }
        public void setCasco(CCasco tmp)
        {
            Magazzino.Add(tmp);
        }
        public string visVenduti()
        {
            string tmp="";
            for (int i = 0; i < Venduti.Count; i++)
            {
                tmp += Venduti.ElementAt(i).visTutto() + "\n";
            }
            return tmp;
        }
        public string visMagazzino()
        {
            string tmp = "";
            for (int i = 0; i < Magazzino.Count; i++)
            {
                tmp += Magazzino.ElementAt(i).visTutto() + "\n";
            }
            return tmp;
        }
        public void vendiCasco(int pos)
        {
            Venduti.Add(Magazzino.ElementAt(pos));
            Magazzino.RemoveAt(pos);
        }
        public CCasco tornaCasco(int pos)
        {
            return Magazzino.ElementAt(pos);
        }
        public int NumElMagazzino()
        {
            return Magazzino.Count;
        }
        public int NumElVenduti()
        {
            return Venduti.Count;
        }
        public CCasco tornaCascoVenduto(int pos)
        {
            return Venduti.ElementAt(pos);
        }
        
    }
}
