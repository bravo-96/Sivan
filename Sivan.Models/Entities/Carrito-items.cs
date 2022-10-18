using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.Entities
{
    [Table(name: "Carrito_items", Schema = "dbo")]

    public class Carrito_items
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

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }


    }
}
