using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERROGAZIONI
{
    class interrogazione
    {
        private string materia, data,nomeAlunno;
        private int voto;

        public interrogazione()
        {
            materia = "";
            data = "";
            voto = 0;
            nomeAlunno = "";
        }

        public interrogazione(string m, string d,string nA,int v)
        {
            materia = m;
            data = d;
            voto = v;
            nomeAlunno = nA;
        }
        public int getVoto()
        {
            return voto;
        }
        public string getMateria()
        {
            return materia;
        }
        public string getData()
        {
            return data;
        }
        public string getAlunno()
        {
            return nomeAlunno;
        }
        public string visTutto()
        {
            string tmp;
            tmp = "Nome: " + nomeAlunno + " Materia: " + materia + " Voto: " + Convert.ToString(voto) + " Data: " + data;
            return tmp;
        }
    }
}
