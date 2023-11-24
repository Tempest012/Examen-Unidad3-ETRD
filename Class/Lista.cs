using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad3_ETRD.Class
{
    internal class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertaNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingresa el dato que contendra la nueva persona: ");
            Nuevo.DatoNombre=Convert.ToString(Console.ReadLine());
            Nuevo.DatoEdad = int.Parse(Console.ReadLine());

            if (Primero == null)
                {
                    Primero = Nuevo;
                    Primero.Siguiente = null;
                    Ultimo = Nuevo;
            }
            else
            {
                    Ultimo.Siguiente = Nuevo;
                    Nuevo.Siguiente = null;
                    Ultimo = Nuevo;
            }
                Console.WriteLine("\n Nodo Ingresafo \n");
            
        }
        public void DesplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("{0}", Actual.DatoNombre);
                    Console.WriteLine("{0}", Actual.DatoEdad);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
            }
        }
        public void BuscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el dato del nodo a buscar: ");
            string nodoBuscado = Convert.ToString(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.DatoNombre == nodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato  Encontrado {0}\n", nodoBuscado);
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n la lista se encuentra vacia\n");
            }
        }
        public void OdernaNodo()
        {
            Nodo Actual =new Nodo();
            Actual = Primero;
            if(Primero != null) 
            {
                for (int h = 0; h < Actual.DatoEdad; h++)
                {
                    for (int j = h + 1; j < Ultimo.DatoEdad; j++)
                    {
                        int aux;
                        if (Actual.DatoEdad > Actual.DatoEdad)
                        {
                            aux = Actual.DatoEdad;
                            Actual.DatoEdad = Actual.DatoEdad;
                            Actual.DatoEdad = aux;
                        }
                    }

                }
            }
            
        }

    }
}
