﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sivan.DataAccess;

namespace Sivan.DataAccess.Migrations
{
    [DbContext(typeof(SivanDbContext))]
    [Migration("20221018190228_ver_1")]
    partial class ver_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sivan.Models.Entities.CarritoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.Property<int>("SesionId")
                        .HasColumnType("int")
                        .HasColumnName("sesion_id");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carrito_items", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.CompraSesion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compras_sesiones", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Descuento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("DescuentoPorcentaje")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaEliminado")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_eliminado");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.HasKey("Id");

                    b.ToTable("descuentos", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Imagenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("imagenes", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagenUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Marca", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.OrdenDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<int>("PagoId")
                        .HasColumnType("int")
                        .HasColumnName("pago_id");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id");

                    b.ToTable("ordenes_detalles", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.OrdenItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<int?>("OrdenDetalleId")
                        .HasColumnType("int");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int")
                        .HasColumnName("orden_detalle_id");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.HasKey("Id");

                    b.HasIndex("OrdenDetalleId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ordenes_items", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.PagoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int")
                        .HasColumnName("orden_id");

                    b.HasKey("Id");

                    b.ToTable("pagos_detalles", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coleccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DescuentoId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("descuento_id");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaEliminado")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_eliminado");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("Marca_Id")
                        .HasColumnType("int")
                        .HasColumnName("marca_id");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("PrecioDescuento")
                        .IsRequired()
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("ProductoCategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("prod_categoria_id");

                    b.Property<int>("ProductoInventarioId")
                        .HasColumnType("int")
                        .HasColumnName("prod_inventario_id");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("char(13)");

                    b.HasKey("Id");

                    b.HasIndex("DescuentoId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ProductoCategoriaId");

                    b.HasIndex("ProductoInventarioId");

                    b.ToTable("productos", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.ProductoCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaEliminado")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_eliminado");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("productos_categorias", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.ProductoInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Cantidad")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaEliminado")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_eliminado");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.HasKey("Id");

                    b.ToTable("productos_inventarios", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.UsuarioDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("codigo_postal");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("Usuario_id");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Usuarios_direcciones", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.UsuarioPagos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MontoCompra")
                        .HasColumnType("int")
                        .HasColumnName("monto_compra");

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("tipo_pago");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Usuarios_pagos", "dbo");
                });

            modelBuilder.Entity("Sivan.Models.Entities.CarritoItem", b =>
                {
                    b.HasOne("Sivan.Models.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sivan.Models.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sivan.Models.Entities.CompraSesion", b =>
                {
                    b.HasOne("Sivan.Models.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Imagenes", b =>
                {
                    b.HasOne("Sivan.Models.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Sivan.Models.Entities.OrdenItem", b =>
                {
                    b.HasOne("Sivan.Models.Entities.OrdenDetalle", "OrdenDetalle")
                        .WithMany()
                        .HasForeignKey("OrdenDetalleId");

                    b.HasOne("Sivan.Models.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdenDetalle");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Sivan.Models.Entities.Producto", b =>
                {
                    b.HasOne("Sivan.Models.Entities.Descuento", "Descuento")
                        .WithMany()
                        .HasForeignKey("DescuentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sivan.Models.Entities.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("Sivan.Models.Entities.ProductoCategoria", "ProductoCategoria")
                        .WithMany()
                        .HasForeignKey("ProductoCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sivan.Models.Entities.ProductoInventario", "ProductoInventario")
                        .WithMany()
                        .HasForeignKey("ProductoInventarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Descuento");

                    b.Navigation("Marca");

                    b.Navigation("ProductoCategoria");

                    b.Navigation("ProductoInventario");
                });

            modelBuilder.Entity("Sivan.Models.Entities.UsuarioDireccion", b =>
                {
                    b.HasOne("Sivan.Models.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sivan.Models.Entities.UsuarioPagos", b =>
                {
                    b.HasOne("Sivan.Models.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}