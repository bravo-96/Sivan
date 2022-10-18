using System;
using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class ProductoInventarioDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Cantidad { get; set; }

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
