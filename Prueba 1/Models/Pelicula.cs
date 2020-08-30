using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Año { get; set; }
        public Genero Genero { get; set; }
        public List<PeliculaActor> Actores { get; set; }
        public Director Director { get; set; }
    }
}
