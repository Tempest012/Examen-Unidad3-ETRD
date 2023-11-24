using Examen_Unidad3_ETRD.Class;
using System.Collections.Generic;

namespace Examen_Unidad3_ETRD
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Lista lista = new Lista();
            int opcion = 0;
            do
            {
                Console.WriteLine("1.Insertar " +
                    "2.Buscar " +
                   "3.Desplegar " +
                   "4.Odernar");

                Console.WriteLine("Escpja su opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Inserta Nodo en la lista");
                        lista.InsertaNodo();
                        break;
                    case 2:
                        Console.WriteLine("Buscar un nodo");
                        lista.BuscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("Modicar Nodo");
                        lista.DesplegarLista();
                        break;
                    case 4:
                        Console.WriteLine("Oderna nodo");
                        lista.OdernaNodo();
                        break;
                   
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            while (opcion != 5);
        }
    }
 }