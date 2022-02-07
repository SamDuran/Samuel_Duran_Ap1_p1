using Microsoft.EntityFrameworkCore;
using Samuel_Duran_Ap1_p1_.Entidades;

public class Contexto : DbContext
{
    public DbSet<Productos> Productos {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite(@"Data Source=DATA/Samuel_Duran_Ap1_p1.db");
    }
}
