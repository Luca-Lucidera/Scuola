using System;
using System.Collections.Generic;
using System.Text;

namespace Edicola
{
    class CQuotidiano
    {
        private string nome;
        private string data;
        private bool allegato;
        private string pdf;

        public CQuotidiano()
        {
            nome = "";
            data = "";
            allegato = false;
            pdf = "";
        }
        public CQuotidiano(string n,string d,bool a,string p)
        {
            nome = n;
            data = d;
            allegato = a;
            pdf = p;
        }

        public string getNome()
        {
            return nome;
        }
        public string getData()
        {
            return data;
        }
        public string getPDF()
        {
            return pdf;
        }

        public bool getAllegato()
        {
            return allegato;
        }
    }
}
