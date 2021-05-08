using StackTest.Clases;
using StackTest.ListaSimple;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Unicode;

namespace StackTest
{
    //@AutorFerdyAgustin
    class Program
    {
        static void ejemploPilaLineal()
        {
            PilaListaEnlazada pila;
            int x;
            int Clave = -1;
            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pila = new PilaListaEnlazada();//crea la pila
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pila.insertar(x);
                    }
                } while (x != Clave);

                Console.WriteLine("Estos son los elementos de la pila:");
                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            }catch(Exception error)
            {
                Console.WriteLine("Error=" + error.Message);
            }
        }

        
        /*se tiene una lista enlazada ala que se accede por el primer nodo
1) Escribir un metodo que imprima los nodos de la lista en orden inverso 
desde el ultimo nodo al primero
2)como estructura auxiliar, utilizar una pila y sus operaciones
*/

        static void listaEnlazada_pila()
        {
            Lista listaEnlazada=new Lista();
            PilaLista pila = new PilaLista();
            listaEnlazada.insertar("R");
            listaEnlazada.insertar("O");
            listaEnlazada.insertar("M");
            listaEnlazada.insertar("A");
            while (listaEnlazada.primero != null)
            {
                pila.insertar(listaEnlazada.primero.dato.ToString());
                listaEnlazada.primero = listaEnlazada.primero.enlace;
                Console.WriteLine(pila.quitar());
            }   
            
        }

        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;
           
            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();
                pal = pal.Replace(" ", String.Empty);
              
                //creamos la pila con los chars
                for (int i = 0; i < pal.Length;)
                {
                    Char c;

                    c = pal[i++];
                
                    pilaChar.insertar(c);

                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c; //evalua si la pos es igual 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }


        }

        /*hacer un programa para evaluar expresiones matematicas, usando la clase pila
lineal o pila lista, la que usted considere*/

        static void evaluarExpresions()
        {
            PilaLista listaExpre = new PilaLista();
            string cadena,caracter;
            int aux=0,resultado=0,multiplicacion=0,divicion=0;
            Console.WriteLine("Ingresa una expresion matematica");
            cadena = Console.ReadLine();

            for(int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena[i].ToString();
                listaExpre.insertar(caracter);   
            }
            for(int j = 0; j < cadena.Length; j++)
            {
                caracter=listaExpre.quitar().ToString();
                if (caracter.Equals("+"))
                {
                    resultado += aux;
                }else if (caracter.Equals("-"))
                {
                    resultado -= aux;
                }
                else if (caracter.Equals("*"))
                {
                    multiplicacion= aux * (int.Parse(listaExpre.quitar().ToString()));
                    aux = 0;
                    j++;
                }
                else if (caracter.Equals("/"))
                {
                    divicion= aux * (int.Parse(listaExpre.quitar().ToString()));
                    aux = 0;
                    j++;
                }
                else
                {
                    aux = int.Parse(caracter);
                }
                resultado += multiplicacion;
                resultado += divicion;
                multiplicacion = 0;
                divicion = 0;
             
            }
            Console.WriteLine("El Resultado Es: {0}",resultado);
            
        }



        static void EjemploPilaLista()
        {
            PilaListaEnlazada pl = new PilaListaEnlazada();
            pl.insertar("1");
            pl.insertar("15");
            pl.insertar("3");
            pl.insertar("4");
            pl.insertar("5");
            Console.WriteLine(pl.quitar());
            Console.WriteLine(pl.quitar());
            Console.WriteLine(pl.quitar());
            Console.WriteLine(pl.quitar());
            Console.WriteLine(pl.quitar());

            int pau;
            pau = 0;
        }


        

        static void Main(string[] args)
        {
            //evaluarExpresions();
            //EjemploPilaLista();
            //palindromo();
            //ejemploPilaLineal();
            //listaEnlazada_pila();

        }
    }
}
