using StackTest.ListaSimple;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.Clases
{
    class PilaListaEnlazada
    {
        
        public int cima;
        private Lista ListaPila=new Lista();


        public PilaListaEnlazada()
        {
            cima = -1;
          //  ListaPila = new ListaOrdenada();
        }

        public void insertar(object elemento)
        {
            cima++;
            ListaPila.insertar(elemento);
        }

        public object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            ListaPila.buscarPosicion(cima);
            aux = ListaPila.primero.dato;
            ListaPila.eliminar(aux);
           
            cima--;
            return aux;
        }

        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            return ListaPila.buscarPosicion(cima);
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
