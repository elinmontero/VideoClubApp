using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheSpartanVideoClub.Data.Enums;

namespace TheSpartanVideoClub.Models
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }

        public string NombrePelicula { get; set; }
        public string DescripcionPelicula { get; set; }        
        public CategoriaPelicula CategoriaPelicula { get; set; }        
        public string FotoPerfilPelicula { get; set; }

        //Relaciones
        public List<Actor_Pelicula> actor_Peliculas { get; set; }

        // Director
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]

        public Director Director { get; set; }



    }
}
