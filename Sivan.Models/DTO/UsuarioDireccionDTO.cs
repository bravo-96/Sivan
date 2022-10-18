using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class UsuarioDireccionDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int UsuarioId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Direccion { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(10)]
        [DataType(DataType.Text)]
        public int CodigoPostal { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

    }
}
