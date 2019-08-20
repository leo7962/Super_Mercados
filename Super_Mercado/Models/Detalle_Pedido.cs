using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Detalle_Pedido
    {
        [Key]

        public long Id { get; set; }



        [Required]

        public Pedido Id_Pedido { get; set; }



        [Required]

        public Producto Id_Producto { get; set; }
    }
}
