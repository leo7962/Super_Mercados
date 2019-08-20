using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Sucursal
    {
        [Key]

        public int Id { get; set; }



        [Required]

        public string Nombre { get; set; }



        [Required]

        public int Telefono { get; set; }



        [Required]

        public int Direccion { get; set; }



        [Required]

        public List<Empleado> Empleados { get; set; }
    }
}
