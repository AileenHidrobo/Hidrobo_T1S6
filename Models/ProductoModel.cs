using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hidrobo_T1S6.Models
{
    public class ProductoModel
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo 4 caracteres")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El campo Lote es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Lote { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaCaducidad { get; set; }

        [Required(ErrorMessage = "El campo Proveedor es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Proveedor { get; set; } = null!;

        [Range(0, uint.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        [Precision(10, 2)]
        [Range(0.0, double.MaxValue, ErrorMessage = "El precio no puede ser negativo")]
        public decimal PrecioUnitario { get; set; }

        public DateTime Create_At { get; set; }
        public DateTime Update_Up { get; set; }
    }
}
