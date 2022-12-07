using System;
using System.Collections.Generic;
using System.Text;

namespace Edicola
{
    class CEdicola
    {
        private List<CQuotidiano> v;
        public CEdicola()
        {
            v = new List<CQuotidiano>();
        }
        public void inserisci(CQuotidiano tmp) 
        {
            v.Add(tmp);
        }
        public void togli(int pos) //se gli passo 1 equivale alla posizione 0
        {
            v.RemoveAt(pos - 1);
        }
        public int quantiQuotidiani()
        {
            return v.Count;
        }
    }
}
