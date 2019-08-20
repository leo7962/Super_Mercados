using Microsoft.EntityFrameworkCore;

using Super_Mercado.Models;



namespace Super_Mercado.Data

{

    public class Super_MercadoContext : DbContext

    {



        public Super_MercadoContext(DbContextOptions<Super_MercadoContext> options) : base(options)

        {

        }



        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Detalle_Pedido> Detalles_De_Pedidos { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Sucursal> Sucursales { get; set; }





    }

}