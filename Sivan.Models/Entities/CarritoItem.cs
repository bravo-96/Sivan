using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "Carrito_items", Schema = "dbo")]

    public class CarritoItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "SesionId")]
        [Column("sesion_id")]
        public int SesionId { get; set; }
        public Usuario Usuario { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "productoId")]
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
