using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas_2._1y2._2.Dominio
{
    internal class Pila : Dominio.ICollection
    {
        private static Pila oPila = null;
        private int contador;
        private object[] array;

        private Pila(int tamaño)
        {
            this.contador = -1;
            this.array = new object[tamaño];
        }

        public static Pila ObtenerInstancia(int tamaño)
        {
            if (oPila == null)
            {
                oPila = new Pila(tamaño);
            }

            return oPila;
        }
        public int Contador { set; get; }
        public object[] Array { set; get; }

        public bool añadir(object NewLibro)
        {
            bool añadido = false;
            if (contador < array.Length)
            {
                array[++contador] = NewLibro;
                añadido = true;
            }
            return añadido;
        }

        public bool estaVacia()
        {
            bool retorno;

            if(array != null)
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
            object oObjeto = new object();

            //for (int i = 0; i < contador; i++)
            //{
            //    if (list_libro[i] != null)
            //    {
            //        oLibro = list_libro[i];

            //        list_libro[i] = null;

            //        break;
            //    }
            //}

            if (array[contador] != null)
            {
                oObjeto = array[contador];
                array[contador] = null;
                contador--;
            }

            return oObjeto;
        }

        public object primero()
        {
            object oObjeto = new object();

            for (int i = 0; i < contador; i++)
            {
                if (array[i] != null)
                {
                    oObjeto = array[i];

                    break;
                }
            }

            return oObjeto;
        }
    }
}
