using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERIFICA_INFORMATICA_GENNAIO_LUCIDERA_LUCA
{
    public class Vino
    {
        private string casa,nome,colore,immagine;
        private int codice_bottiglia;
        public Vino()
        {
            this.casa = "";
            this.nome = "";
            this.colore = "";
            this.immagine = "";
            this.codice_bottiglia = 0;
        }
    public Vino(string casa, string nome, string colore, string immagine, int codice_bottiglia)
        {
            this.casa = casa;
            this.nome = nome;
            this.colore = colore;
            this.immagine = immagine;
            this.codice_bottiglia = codice_bottiglia;
        }
        public string getCasa()
        {
            return casa;
        }
        public string getNome()
        {
            return nome;
        }
        public string getColore()
        {
            return colore;
        }
        public string getImmagine()
        {
            return immagine;
        }
        public int getCodice()
        {
            return codice_bottiglia;
        }
        public override string ToString()
        {
            return casa + " " + nome + " " + colore + " " + immagine + " " + codice_bottiglia;
        }
        public  string toCsv()
        {
            return casa + ";" + nome + ";" + colore + ";" + immagine + ";" + codice_bottiglia;
        }
    }
}
