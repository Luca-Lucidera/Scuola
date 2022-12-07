using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimoProgetto
{
    class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona()
        {
            this.nome = "";
            this.cognome = "";
            this.eta = 0;
        }
        public Persona(string n, string c, int e)
        {
            this.nome = n;
            this.cognome = c;
            this.eta = e;
        }
        public string presentati()
        {
            string tmp = this.nome + " " + this.cognome + " " + this.eta.ToString();
            return tmp;
        }
        public void setPresona(string n,string c,int e)
        {
            this.nome = n;
            this.cognome = c;
            this.eta = e;
        }
    }
}
