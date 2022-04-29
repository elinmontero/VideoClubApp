using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheSpartanVideoClub.Data.Enums;

namespace TheSpartanVideoClub.Models
{
    public class Actor_Pelicula
    {
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

    }
}
