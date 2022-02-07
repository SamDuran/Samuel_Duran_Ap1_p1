using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite(@"Data Source=DATA/Samuel_Duran_Ap1_p1.db");
    }
}
