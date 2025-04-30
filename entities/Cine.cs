using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2.entities
{
    public class Cine
    {
        public string Codigo { get; set; }
        public string Direccion { get; set; }
        public double Area { get; set; }
        public string Gerente { get; set; }
        public int Capacidad { get; set; }
        public string NomCine { get; set; }

        public Cine(string codigo, string direccion, double area, string gerente, int capacidad, string nomcine) 
        {
            Codigo = codigo;
            Direccion = direccion;
            Area = area;
            Gerente = gerente;
            Capacidad = capacidad;
            NomCine = nomcine;
        }

    }
}
