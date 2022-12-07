using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica_di_persone
{
    class CRubrica
    {
        private List<CPersona> rub; //al posto del vettore uso le liste
        public CRubrica()
        {
            this.rub = new List<CPersona>(); //inizializzazione della lista senza FOR
        }
        /*public CRubrica (CPersona x) //costruttore parametrico
        {
            
        }
        */
        public void aggiungiPersona (CPersona p)
        {
            rub.Add(p); //si usa Add per inserire un elemento nella lista
        }
        public void eliminaPersona(int x)
        {
            rub.RemoveAt(x); //si usa RemoveAt per rimuovere un elemento nella lista (passo come parametro la posizione, si inizia da 0)
        }
        public int numElementi()
        {
            return rub.Count();//Count restituisce quanti elementi ci sono nella lista
        }
        public string megaVisTutto()
        {
            string s = " ";
            for (int i = 0; i < rub.Count(); i++)
            {
                //non avendo più la poszione del vettore, ora si usa il metodo ElementAt che gli viene passato per parametro l'elemento che si vuole usare
                s += rub.ElementAt(i).presentati() + "\n";
            }
            return s;
        }
        public void salva(string s)
        {
            //salvo nel bin del progetto un txt con tutta la roba visualizzata
            System.IO.File.WriteAllText("exportAll.txt", s);
        }
    }
}