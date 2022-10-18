using System;
using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class UsuarioDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string NombreUsuario { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Contraseña { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }

    }
}
