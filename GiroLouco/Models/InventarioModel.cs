using System.ComponentModel.DataAnnotations;

namespace GiroLouco.Models
{
    public class InventarioModel
    {
        [Key]
        public int iditem { get; set; }
        public int idcliente { get; set; }
        public int idmaquina { get; set; }
        public int quantidade { get; set; }
        public string valor { get; set; }

        public List<Clientes> listaclientes { get; set;}
        public List<Maquinas> listamaquinas { get; set; }
    }
}
