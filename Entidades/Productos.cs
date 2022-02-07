using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public partial class Productos
{
    [Key]
    public int ProductoId { get; set; }
    public string? Descripcion { get; set; }
    public bool Existencia { get; set; }
    public decimal Costo { get; set; }
    public decimal ValorInventario { get; set; }
}