using System;
using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class UsuarioPagosDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int UsuarioId { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string TipoPago { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public int MontoCompra { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Banco { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime Vencimiento { get; set; }
    }
}
