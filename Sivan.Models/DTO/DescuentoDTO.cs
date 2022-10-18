using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.DTO
{
    public class DescuentoDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int DescuentoPorcentaje { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public bool Activo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaModificacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaEliminado { get; set; }
    }
}
