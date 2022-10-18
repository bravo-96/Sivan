using System;
using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class PagoDetalleDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(60)]
        public string Banco { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(30)]
        [DataType(DataType.Text)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaModificacion { get; set; }
    }
}
