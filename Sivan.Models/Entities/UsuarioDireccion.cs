using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.Entities
{
    [Table(name: "UsuarioDireccion", Schema = "dbo")]

    public class UsuarioDireccion
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "UsuarioId")]
        public int UsuarioId { get; set; }
        //public Usuario Usuario {get; set;}

        [StringLength(200)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Direccion { get; set; }


        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Ciudad { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public int CodigoPostal { get; set; }


        [StringLength(180)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }


    }
}
