using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.DTO
{
    public class ImagenesDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ProductoId { get; set; }


        [StringLength(200)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Url)]
        public string URL { get; set; }
    }
}
