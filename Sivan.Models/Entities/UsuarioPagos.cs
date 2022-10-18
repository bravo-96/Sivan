using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivan.Models.Entities
{
    [Table(name: "Usuarios_pagos", Schema = "dbo")]

    public class UsuarioPagos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "usuario_id")]
        [Column("usuario_id")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        [Column("tipo_pago")]
        public string TipoPago { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        [Column("monto_compra")]
        public int MontoCompra { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Banco { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.DateTime)]
        public DateTime Vencimiento { get; set; }
    }
}
