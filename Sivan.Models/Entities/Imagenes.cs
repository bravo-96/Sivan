using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{

    [Table(name: "imagenes", Schema = "dbo")]
    public class Imagenes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "producto_id")]
        [Column("producto_id")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Url)]
        public string URL { get; set; }

    }
}
