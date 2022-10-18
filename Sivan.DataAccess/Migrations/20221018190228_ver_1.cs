using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sivan.DataAccess.Migrations
{
    public partial class ver_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "descuentos",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescuentoPorcentaje = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_descuentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ordenes_detalles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    pago_id = table.Column<int>(type: "int", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenes_detalles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pagos_detalles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orden_id = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagos_detalles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productos_categorias",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos_categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productos_inventarios",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<short>(type: "smallint", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos_inventarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Coleccion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    marca_id = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: true),
                    Sku = table.Column<string>(type: "char(13)", nullable: false),
                    prod_categoria_id = table.Column<int>(type: "int", nullable: false),
                    prod_inventario_id = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PrecioDescuento = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    descuento_id = table.Column<int>(type: "int", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productos_descuentos_descuento_id",
                        column: x => x.descuento_id,
                        principalSchema: "dbo",
                        principalTable: "descuentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalSchema: "dbo",
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_productos_categorias_prod_categoria_id",
                        column: x => x.prod_categoria_id,
                        principalSchema: "dbo",
                        principalTable: "productos_categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_productos_inventarios_prod_inventario_id",
                        column: x => x.prod_inventario_id,
                        principalSchema: "dbo",
                        principalTable: "productos_inventarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras_sesiones",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras_sesiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_sesiones_Usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalSchema: "dbo",
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios_direcciones",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario_id = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    codigo_postal = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios_direcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_direcciones_Usuarios_Usuario_id",
                        column: x => x.Usuario_id,
                        principalSchema: "dbo",
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios_pagos",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    tipo_pago = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    monto_compra = table.Column<int>(type: "int", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios_pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_pagos_Usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalSchema: "dbo",
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrito_items",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sesion_id = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    producto_id = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrito_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrito_items_productos_producto_id",
                        column: x => x.producto_id,
                        principalSchema: "dbo",
                        principalTable: "productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrito_items_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "dbo",
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producto_id = table.Column<int>(type: "int", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_productos_producto_id",
                        column: x => x.producto_id,
                        principalSchema: "dbo",
                        principalTable: "productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordenes_items",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orden_detalle_id = table.Column<int>(type: "int", nullable: false),
                    OrdenDetalleId = table.Column<int>(type: "int", nullable: true),
                    producto_id = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenes_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordenes_items_ordenes_detalles_OrdenDetalleId",
                        column: x => x.OrdenDetalleId,
                        principalSchema: "dbo",
                        principalTable: "ordenes_detalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordenes_items_productos_producto_id",
                        column: x => x.producto_id,
                        principalSchema: "dbo",
                        principalTable: "productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_items_producto_id",
                schema: "dbo",
                table: "Carrito_items",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_items_UsuarioId",
                schema: "dbo",
                table: "Carrito_items",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_sesiones_usuario_id",
                schema: "dbo",
                table: "Compras_sesiones",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_producto_id",
                schema: "dbo",
                table: "imagenes",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_ordenes_items_OrdenDetalleId",
                schema: "dbo",
                table: "ordenes_items",
                column: "OrdenDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_ordenes_items_producto_id",
                schema: "dbo",
                table: "ordenes_items",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_productos_descuento_id",
                schema: "dbo",
                table: "productos",
                column: "descuento_id");

            migrationBuilder.CreateIndex(
                name: "IX_productos_MarcaId",
                schema: "dbo",
                table: "productos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_prod_categoria_id",
                schema: "dbo",
                table: "productos",
                column: "prod_categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_productos_prod_inventario_id",
                schema: "dbo",
                table: "productos",
                column: "prod_inventario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_direcciones_Usuario_id",
                schema: "dbo",
                table: "Usuarios_direcciones",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_pagos_usuario_id",
                schema: "dbo",
                table: "Usuarios_pagos",
                column: "usuario_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrito_items",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Compras_sesiones",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "imagenes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ordenes_items",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "pagos_detalles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Usuarios_direcciones",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Usuarios_pagos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ordenes_detalles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "productos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "descuentos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Marca",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "productos_categorias",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "productos_inventarios",
                schema: "dbo");
        }
    }
}
