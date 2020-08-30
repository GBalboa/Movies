using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<PeliculaActor> Peliculas { get; set; }
    }
}
