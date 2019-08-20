﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Mercado.Data;

namespace Super_Mercado.Migrations
{
    [DbContext(typeof(Super_MercadoContext))]
    [Migration("20190820055948_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Super_Mercado.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<int>("Documento");

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Super_Mercado.Models.Detalle_Pedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Id_PedidoId");

                    b.Property<long>("Id_ProductoId");

                    b.HasKey("Id");

                    b.HasIndex("Id_PedidoId");

                    b.HasIndex("Id_ProductoId");

                    b.ToTable("Detalles_De_Pedidos");
                });

            modelBuilder.Entity("Super_Mercado.Models.Empleado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<int>("Documento");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("SucursalId");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Super_Mercado.Models.Pedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Id_ClienteId");

                    b.Property<long>("Id_Detalle");

                    b.Property<long>("Id_EmpleadoId");

                    b.Property<int>("Id_SucursalId");

                    b.HasKey("Id");

                    b.HasIndex("Id_ClienteId");

                    b.HasIndex("Id_EmpleadoId");

                    b.HasIndex("Id_SucursalId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Super_Mercado.Models.Producto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("stock");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Super_Mercado.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Direccion");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("Super_Mercado.Models.Detalle_Pedido", b =>
                {
                    b.HasOne("Super_Mercado.Models.Pedido", "Id_Pedido")
                        .WithMany()
                        .HasForeignKey("Id_PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Super_Mercado.Models.Producto", "Id_Producto")
                        .WithMany()
                        .HasForeignKey("Id_ProductoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Super_Mercado.Models.Empleado", b =>
                {
                    b.HasOne("Super_Mercado.Models.Sucursal", "Sucursal")
                        .WithMany("Empleados")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Super_Mercado.Models.Pedido", b =>
                {
                    b.HasOne("Super_Mercado.Models.Cliente", "Id_Cliente")
                        .WithMany()
                        .HasForeignKey("Id_ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Super_Mercado.Models.Empleado", "Id_Empleado")
                        .WithMany()
                        .HasForeignKey("Id_EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Super_Mercado.Models.Sucursal", "Id_Sucursal")
                        .WithMany()
                        .HasForeignKey("Id_SucursalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}