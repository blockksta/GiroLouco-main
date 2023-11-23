using System.ComponentModel.DataAnnotations;

namespace GiroLouco.Models
{
    public class Clientes
    {
        [Key]
        public int idcliente { get; set; }
        public string nomecliente { get; set; }    
        public string sobrenome { get; set; }
        public string cpf { get; set; }

    }
}
