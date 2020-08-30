using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_1.Models
{
    public class PeliculaActor
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
