using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Samuel_Duran_Ap1_p1_.Entidades
{
    public partial class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string? Descripcion { get; set; }
        public decimal Existencia { get; set; }
        public decimal Costo { get; set; }
        public decimal ValorInventario { get; set; }
    }
}