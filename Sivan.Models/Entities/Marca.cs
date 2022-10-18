using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "Marca", Schema = "dbo")]
    public class Marca
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string ImagenUrl { get; set; }


    }
}
