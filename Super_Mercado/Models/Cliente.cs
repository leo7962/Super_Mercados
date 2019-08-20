using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Cliente
    {
        [Key]

        public long Id { get; set; }



        [Required]

        public int Documento { get; set; }



        [Required]

        public string Nombre { get; set; }



        [Required]

        public string Apellido { get; set; }



        [Required]

        public bool Estado { get; set; } = true;
    }
}
