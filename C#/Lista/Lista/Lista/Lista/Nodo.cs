using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Nodo
    {
        public int info;
        public Nodo next;
        public Nodo()
        {
            info = 0;
            next = null;
        }
        public void eliminaNodo(int pos)
        {
            if(pos != 1)
            {
                pos--;
                next.eliminaNodo(pos);
            }
            else
            {
                next = next.next;
            }
        }
    }
}
