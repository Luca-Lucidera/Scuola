using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica_di_persone
{
    class CPersona
    {
        private string nome;
        private string cognome;

        public CPersona()
        {
            this.nome = "";
            this.cognome = "";
        }
        public CPersona(string n, string c)
        {
            this.nome = n;
            this.cognome = c;
        }
        public string presentati()
        {
            string tmp = this.nome + " " + this.cognome;
            return tmp;
        }
        public void setPresona(string n, string c)
        {
            this.nome = n;
            this.cognome = c;
        }
    }
}
