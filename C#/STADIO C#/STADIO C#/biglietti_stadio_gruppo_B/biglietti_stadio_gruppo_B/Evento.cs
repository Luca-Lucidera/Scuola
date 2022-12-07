using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biglietti_stadio_gruppo_B
{
    public class Evento
    {
        private string nome,data;
        private int prezzo;
        public Evento()
        {
            nome = "";
            data = "";
            prezzo = 0;
        }
        public Evento(string nome,string data, int prezzo)
        {
            this.nome = nome;
            this.data = data;
            this.prezzo = prezzo;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setData(string data)
        {
            this.data = data;
        }
        public void setPrezzo(int prezzo)
        {
            this.prezzo = prezzo;
        }
        public string getNome()
        {
            return nome;
        }
        public string getData()
        {
            return data;
        }
        public int getPrezzo()
        {
            return prezzo;
        }
        public override string ToString()
        {
            return "Evento: " + nome + " giorno: " + data + " prezzo: " + prezzo;  
        }
        public string toCSV()
        {
            return nome + ";" + data + ";" + prezzo;
        }
    }
}
