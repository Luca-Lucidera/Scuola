using System;
using System.Collections.Generic;
using System.Text;

namespace Canile
{
    class Cane
    {
        private string nome, idChip, razza,prov,immagine;
        private string peso;
        private bool sesso, vaccino;
        public Cane()
        {
            nome = "";
            idChip = "";
            razza = "";
            prov = "";
            peso = "";
            sesso = true; 
            vaccino=true;
            immagine = "";
        }
        public Cane(string n, string id, string raz, string pr, string i,string p,bool r,bool v)
        {
            nome = n;
            idChip = id;
            razza = raz;
            prov = pr;
            immagine = i;
            peso = p;
            sesso = r;
            vaccino = v;
        }
        public string getNome()
        {
            return nome;
        }
        public string getIdChip()
        {
            return idChip;
        }
        public string getImmagine()
        {
            return immagine;
        }
        public string getPeso()
        {
            return peso;
        }
        public string getRazza()
        {
            return razza;
        }
        public string getProv()
        {
            return prov;
        }
        public bool getSesso()
        {
            return sesso;
        }
        public bool getVaccino()
        {
            return vaccino;
        }
        public string visTutto()
        {
            string r, v;
            if (sesso == true)
                r = " maschio ";
            else r = "femmina";
            if (vaccino == true)
                v = "Vaccinato!";
            else v = "non vaccinato";
            string tmp;
            tmp = "Nome: " + nome + " id Chip: " + idChip + " razza: " + razza + " prov: " + prov + "\n peso " + peso + "sesso" + r + " " + v;
            return tmp;
        }
    }
}
