using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2.entities
{
    public class Pelicula
    {
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public double Valoracion { get; set; }
        public string Genero { get; set; }
        public int DuracionMinutos { get; set; }
        public string Clasificacion { get; set; }

        public Pelicula(string codigo, string titulo, double area, double valoracion, string genero, int duracionMinutos, string clasificacion)
        {
            Codigo = codigo;
            Titulo = titulo;
            Valoracion = valoracion;
            Genero = genero;
            DuracionMinutos = duracionMinutos;
            Clasificacion = clasificacion;
        }

    }

}
