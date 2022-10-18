using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.DTO
{
    public class CarritoItemsDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Display(Name = "Sesion")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int SesionId { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ProductoId { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Cantidad { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaModificacion { get; set; }

    }
}
