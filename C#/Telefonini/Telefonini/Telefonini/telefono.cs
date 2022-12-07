using System;
using System.Collections.Generic;
using System.Text;

namespace Telefonini
{
    public class telefono
    {
        private string marca, codiceSeriale, modello, immagine;
        private bool g4; //4g
        public telefono()
        {
            marca = "";
            codiceSeriale = "";
            modello = "";
            immagine = "";
            g4 = true;
        }
        public telefono(string m, string cS, string mo, string i, bool g)
        {
            marca = m;
            codiceSeriale = cS;
            modello = mo;
            immagine = i;
            g4 = g;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getCodiceSeriale()
        {
            return codiceSeriale;
        }
        public string getModello()
        {
            return modello;
        }
        public string getImmagine()
        {
            return immagine;
        }
        public bool getG4()
        {
            return g4;
        }
        public string visTutto()
        {
            string tmp;
            if (g4 == true)
            {
                tmp = marca + " " + modello + " " + codiceSeriale + " 4G";
            }
            else
            {
                tmp = marca + " " + modello + " " + codiceSeriale + " 5G";
            }
            return tmp;

        }
    }
}
