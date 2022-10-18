using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.DTO
{
    public class OrdenDetalleDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int PagoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaModificacion { get; set; }
    }
}
