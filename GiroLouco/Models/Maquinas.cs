using System.ComponentModel.DataAnnotations;

namespace GiroLouco.Models
{
    public class Maquinas
    {
        [Key]
        public int idmaquina { get; set; }
        public string tipo { get; set; }
        public string patrimonio { get; set; }
        public string memoria { get; set; } 
    }
}
