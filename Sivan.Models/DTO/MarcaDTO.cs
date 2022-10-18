using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class MarcaDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [StringLength(500)]
        [DataType(DataType.ImageUrl)]
        public string ImagenUrl { get; set; }
    }
}
