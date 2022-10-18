using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.Entities
{
    [Table(name: "CarritoItems", Schema = "dbo")]

    public class CarritoItems
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "SesionId")]
        public int SesionId { get; set; }
        //public Usuario Usuario {get; set;}


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "ProductoId")]
        public int ProductoId { get; set; }
        //public Producto Producto {get; set;}

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Cantidad { get; set; }

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
