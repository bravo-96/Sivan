using Sivan.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sivan.Models.DTO
{
    public class ProductoDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255)]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(500)]
        [DataType(DataType.Text)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(60)]
        [DataType(DataType.Text)]
        public string Coleccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Marca_Id { get; set; }
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Sku { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ProductoCategoriaId { get; set; }
        public ProductoCategoriaDTO ProductoCategoria { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ProductoInventarioId { get; set; }
        public ProductoInventarioDTO ProductoInventario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal? PrecioDescuento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? DescuentoId { get; set; }
        public DescuentoDTO Descuento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaModificacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaEliminado { get; set; }
    }
}
