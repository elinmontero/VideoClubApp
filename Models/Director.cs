using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheSpartanVideoClub.Models
{
    public class Director
    {
        [Key]
        public int IdDirector { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string FotoPerfilDirector { get; set; }

        [Display(Name = "Nombre")]
        public string NombreDirector { get; set; }

        // Relaciones de tablas

        public List<Pelicula> peliculas { get; set; }
    }
}
