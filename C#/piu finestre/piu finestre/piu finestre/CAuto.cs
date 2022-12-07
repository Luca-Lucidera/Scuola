using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piu_finestre
{
    public class CAuto
    {
        private string marca, modello, foto;
        private int anno;
        public CAuto()
        {
            marca = "";
            modello = "";
            foto = "";
            anno = 0;
        }
        public CAuto(string m, string mo, string f, int a)
        {
            marca = m;
            modello = mo;
            foto = f;
            anno = a;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getModello()
        {
            return modello;
        }
        public string getFoto()
        {
            return foto;
        }
        public int getAnno()
        {
            return anno;
        }
        public override string ToString()
        {
            string tmp;
            tmp = marca + " " + modello + " " + anno;
            return tmp;
        }
    }
}
