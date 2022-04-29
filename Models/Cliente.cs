using System.ComponentModel.DataAnnotations;

namespace TheSpartanVideoClub.Models
{
    public class Cliente
    {
        [Key]

        public int IdCliente { get; set; }
        public string CedulaCliente { get; set; }
        public string TarjetaCredito { get; set; }
        public double LimiteCredito { get; set; }

    }
}
