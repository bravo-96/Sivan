using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "Usuarios_direcciones", Schema = "dbo")]

    public class UsuarioDireccion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "Usuario_id")]
        [Column("Usuario_id")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(10)]
        [Column("codigo_postal")]
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
