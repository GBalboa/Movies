using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Pelicula> Peliculas { get; set; }
    }
}
