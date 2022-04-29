using System;
using System.ComponentModel.DataAnnotations;
using TheSpartanVideoClub.Data.Enums;

namespace TheSpartanVideoClub.Models
{
    public class Empleado
    {
        [Key]

        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string CedulaEmpleado { get; set; }    
        public double PorcientoComision { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
