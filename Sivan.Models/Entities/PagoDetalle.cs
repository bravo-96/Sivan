using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "pagos_detalles", Schema = "dbo")]
    public class PagoDetalle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("orden_id")]
        [Column("orden_id")]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(60)]
        [DataType(DataType.Text)]
        public string Banco { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(30)]
        [DataType(DataType.Text)]
        public string Estado { get; set; }

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
