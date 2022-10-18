using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.Entities
{
    [Table(name: "Usuarios_pagos", Schema = "dbo")]

    public class Usuarios_pagos
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
        public string TipoPago { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public int MontoCompra { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Banco { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime Vencimiento { get; set; }


    }
}
