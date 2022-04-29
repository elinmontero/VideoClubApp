
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheSpartanVideoClub.Data.Enums;

namespace TheSpartanVideoClub.Models
{
    public class Actor
    {
        [Key]
        public int IdActor { get; set; }

        [Display(Name = "Foto de Perfil")]
        [Required (ErrorMessage ="Se requiere foto de perfil")]
        public string FotoPerfilActor { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="Se requiere el nombre")]
        [StringLength (50, MinimumLength =3, ErrorMessage ="El nombre debe tener de 3 a 50 caracteres")]
        public string NombreActor { get; set; }

        // Tabla relacional
        public List<Actor_Pelicula> actor_Peliculas { get; set; }       
    }
}
