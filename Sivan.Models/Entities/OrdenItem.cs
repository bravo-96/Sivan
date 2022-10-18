using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "ordenes_items", Schema = "dbo")]
    public class OrdenItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("orden_detalle_id")]
        [Column("orden_detalle_id")]
        public int OrdenId { get; set; }
        public OrdenDetalle OrdenDetalle { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("producto_id")]
        [Column("producto_id")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_modificacion")]
        public DateTime FechaModificacion { get; set; }
    }
}
