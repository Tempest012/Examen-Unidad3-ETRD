using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad3_ETRD.Class
{
    internal class Nodo
    {
        private string datoNombre;
        private int datoEdad;
        private Nodo siguiente;

        public string DatoNombre
        {
            get { return datoNombre;}
            set { datoNombre = value; }
        }
        public int DatoEdad
        {
            get { return datoEdad;}
            set { datoEdad = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente;}
            set { siguiente = value; }
        }
    }
}
