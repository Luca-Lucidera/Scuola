using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibri
{
    public class Libreria
    {
        List<Libro> v;
        public Libreria()
        {
            v = new List<Libro>();
        }
        public void setLibro(Libro tmp)
        {
            v.Add(tmp);
        }
        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < v.Count; i++)
            {
                tmp += v.ElementAt(i).ToString() + "\n";
            }
            return tmp;
        }
        public string tornaImmagine()
        {
            return "";
        }
        public int conta()
        {
            return v.Count();
        }
        public List<Libro> getLibreria()
        {
            return v;
        }
    }
}
