using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas_2._1y2._2.Dominio
{
    internal class Cola : ICollection
    {
        private List<Cola> colaList;
        private int contador;
        private static Cola oCola = null;
        private Cola(int tamaño)
        {
            contador = 0;
            colaList = new List<Cola>(tamaño);
        }
        public static Cola ObtenerInstancia(int tamaño)
        {
            if (oCola == null)
            {
                oCola = new Cola(tamaño);
            }

            return oCola;
        }
        public bool añadir(object Cola)
        {
            bool añadido = false;
            if (contador < colaList.Count)
            {
                Cola cola = colaList[contador++];
                añadido = true;
            }
            return añadido;

        }

        public bool estaVacia()
        {
            bool retorno;

            if (colaList != null)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
            }

            return retorno;
        }

        public object extraer()
        {
            object P = null;
            for (int i = 0; i < colaList.Count; i++)
            {
                if (colaList[i] != null && estaVacia() != true)
                {
                    P = colaList[i];
                    colaList[i] = null;
                    contador--;
                    break;
                }

            }
            return P;
        }

        public object primero()
        {
            object p = null;
            if (estaVacia() != true)
            {
                p = colaList[0];
            }
            return p;

        }
    }
}
