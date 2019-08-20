using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Producto
    {
        [Key]

        public long Id { get; set; }



        [Required]

        public string Nombre { get; set; }



        [Required]

        public int stock { get; set; }
    }
}
