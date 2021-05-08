using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest.ListaSimple
{
    class Nodon
    {
        public object dato;
        public Nodon enlace;

        public Nodon(object x)
        {
            dato = x;
            enlace = null;
        }

        public Nodon(object x, Nodon n)
        {
            dato = x;
            enlace = n;
        }

        public object getDato()
        {
            return dato;
        }
        public Nodon getEnlace()
        {
            return enlace;
        }

        public void setEnlace(Nodon Enlace)
        {
            this.enlace = Enlace;
        }

    }
}
