using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.ListaSimple
{
    class ListaOrdenada:Lista
    {
        public ListaOrdenada insertaOrden(string entrada)
        {
            Nodon nuevo;
            nuevo = new Nodon(entrada);
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                nuevo.setEnlace(primero);
                primero = nuevo;
            }
          
            return this;

        }
    }
}
