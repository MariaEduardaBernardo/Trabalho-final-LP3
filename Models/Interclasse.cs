using Microsoft.EntityFrameworkCore;

namespace Interclasse.Models;

public class InterclasseContext : DbContext
{
    public DbSet<Atleta>?  Atleta { get; set; }
    public DbSet<Esporte>? Esporte { get; set; }
    public DbSet<Time>?  Time { get; set; }
    public DbSet<Quadra>?  Quadra { get; set; }
    public DbSet<Partida>?  Partida { get; set; }
    public DbSet<Juiz>?  Juiz { get; set; }

    public InterclasseContext(DbContextOptions<InterclasseContext> options) : base(options)
    {
    }
}