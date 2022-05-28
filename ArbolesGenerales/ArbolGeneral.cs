using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGenerales
{
    public class ArbolGeneral
    {
        private readonly Nodo raiz;

        //public Nodo Raiz => raiz; (hace lo miso que el de abajo EXPRESION LANDA)
        public Nodo Raiz { get { return raiz; } }

        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo InsertarHijo(Nodo padre, string dato)
        {
            if (string.IsNullOrWhiteSpace(dato)) {
                throw new Exception("El dato esta vacio");

            }
            if(padre is null)
            {
                throw new Exception("El padre no puede ser nulo");
            }

            if(padre.Hijo is null)
            {
                padre.Hijo = new Nodo(dato);
                return padre.Hijo;
            }
            else
            {
                Nodo hijoActual = padre.Hijo;

                while (hijoActual.Hermano != null)//tambien se puede usar its not en vez de !=
                {
                    hijoActual = hijoActual.Hermano;

                }
                hijoActual.Hermano = new Nodo(dato);
                return hijoActual.Hermano;

            }

        }

    }
}
