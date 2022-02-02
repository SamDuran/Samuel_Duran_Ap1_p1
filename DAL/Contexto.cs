using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite(@"DataSource=DATA/Samuel_Duran_Ap1_p1.db");
    }
}
