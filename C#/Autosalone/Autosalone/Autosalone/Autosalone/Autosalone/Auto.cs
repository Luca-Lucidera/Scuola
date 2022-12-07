using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalone
{
    class Auto
    {
        //l'attributo immagine si intende il percorso sul computer
        private string marca, targa, anno, immagine;
        public Auto()
        {
            this.marca = "";
            this.targa = "";
            this.anno = "";
            this.immagine = "";
        }
        public Auto(string m,string t,string a,string im)
        {
            this.marca = m;
            this.targa = t;
            this.anno = a;
            this.immagine = im;
        }
        public string visTutto()
        {
            string tmp = "Marca: " + this.marca + " targa: " + this.targa + " anno: " + this.anno + " immagine " + this.immagine;
            return tmp;
        }
        public string getMarca()
        {
            return marca; 
        }
        public string getTarga()
        {
            return targa;
        }
        public string getAnno()
        {
            return anno;
        }
        public string getImmagine()
        {
            return immagine;
        }
    }
}
