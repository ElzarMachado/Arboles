using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGenerales
{
    public class Nodo
    {
        public string Dato { get; set; }  //prop tab tab
        public Nodo Hijo { get; set; }
        public Nodo Hermano { get; set; }

        public Nodo(string dato, Nodo hijo = null, Nodo hermano = null) //ctor tab tab 
        {
            Dato = dato;
            Hijo = hijo;
            Hermano = hermano;
        }
    }
}
