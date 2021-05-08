using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace StackTest.Clases
{
    class PilaLista
    {
        //private static int Tampila = 49;
        private int cima;
        private List<object> ListaPila;


        public PilaLista()
        {
            cima = -1;
            ListaPila = new List<object>();
        }

        public void insertar(object elemento)
        {
            cima++;
            ListaPila.Add(elemento);
        }

        public object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            aux = ListaPila.ElementAt(cima);
            ListaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        

        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            return ListaPila.ElementAt(cima);
        }


        public bool pilaVacia()
        {
            return cima == -1;
        }

   
        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }


    }



}
    
   


