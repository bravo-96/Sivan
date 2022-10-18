using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "Compras_sesiones", Schema = "dbo")]

    public class CompraSesion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "UsuarioId")]
        [Column("usuario_id")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Total { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        [Column("fecha_modificacion")]
        public DateTime FechaModificacion { get; set; }
    }
}
