using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.Clases
{
    class PilaLineal
    {
        private static int Tampila = 49;
        private int cima;
        private object[] ListaPila;

        public PilaLineal()
        {
            cima = -1;
            ListaPila = new object[Tampila];
        }

        public bool pilaLlena()
        {
            return cima == (Tampila - 1);
        }

        //operaciones que modifican la pila
        public void insertar(object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }
            //incrementar puntero cima y vamos a insertar elemento
            cima++;
            ListaPila[cima] = elemento;
        }

        public bool pilaVacia()
        {
            return cima== -1;
        }


        //retorna un tipo char
        public object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no hay data");
            }
            aux = (char)ListaPila[cima];
            cima--;
            return aux;
        }


        //extraer elemento de la pila
        public object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La Pila esta vacia, no se puede sacar");
            }
            //guardar el elemento en la cima
            aux = (int)ListaPila[cima];
            //decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }


        public void limpiarPila()
        {
            cima = -1;
        }

        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("pila vacia");
            }
            return ListaPila[cima];
        }

    }
}
