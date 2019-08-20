using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Pedido
    {
        [Key]

        public long Id { get; set; }



        [Required]

        public Sucursal Id_Sucursal { get; set; }



        [Required]

        public Empleado Id_Empleado { get; set; }



        [Required]

        public Cliente Id_Cliente { get; set; }



        [Required]

        public long Id_Detalle { get; set; }
    }
}
