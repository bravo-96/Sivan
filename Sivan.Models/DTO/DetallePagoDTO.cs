using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.DTO
{
    [Table(name: "detalle_pago")]
    public class DetallePagoDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("orden_id")]
        [Column("orden_id")]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255)]
        [Column("Descripcion")]
        [DataType(DataType.Text)]
        public string Banco { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255)]
        [Column("Descripcion")]
        [DataType(DataType.Text)]
        public string Estado { get; set; } // !!!!!!

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
