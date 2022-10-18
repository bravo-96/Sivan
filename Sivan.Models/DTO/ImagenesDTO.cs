using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class ImagenesDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ProductoId { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Url)]
        public string URL { get; set; }
    }
}
