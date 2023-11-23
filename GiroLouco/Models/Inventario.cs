using System.ComponentModel.DataAnnotations;

namespace GiroLouco.Models
{
    public class Inventario
    {
        [Key]
        public int iditem { get; set; }
        public int idcliente { get; set; }
        public int idmaquina { get; set; }
        public int quantidade { get; set; }
        public string valor { get; set; }
    }
}
