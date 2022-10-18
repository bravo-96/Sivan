﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.DTO
{
    [Table(name: "Productos")]
    public class ProductoDTO
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "El campo {0} es requerido")]
        //[StringLength(255)]
        //[DataType(DataType.Text)]
        //public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255)]
        [Column("Descripcion")]
        [DataType(DataType.Text)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255)]
        [Column("Descripcion")]
        [DataType(DataType.Text)]
        public string Coleccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("marca_id")]
        [Column("marca_id")]
        public int Marca_Id { get; set; }
        //public Marca Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column(TypeName = "char(13)")]
        [DataType(DataType.Text)]
        public string Sku { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("prod_categoria_id")]
        [Column("prod_categoria_id")]
        public int ProductoCategoriaId { get; set; }
        public ProductoCategoriaDTO ProductoCategoria { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("prod_inventario_id")]
        [Column("prod_inventario_id")]
        public int ProductoInventarioId { get; set; }
        public ProductoInventarioDTO ProductoInventario { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? PrecioDescuento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("descuento_id")]
        [Column("descuento_id")]
        public int DescuentoId { get; set; }
        public DescuentoDTO Descuento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_modificacion")]
        public DateTime FechaModificacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_eliminado")]
        public DateTime FechaEliminado { get; set; }
    }
}
