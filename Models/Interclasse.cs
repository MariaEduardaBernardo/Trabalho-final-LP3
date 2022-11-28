using Microsoft.EntityFrameworkCore;

namespace Interclasse.Models;

public class InterclasseContext : DbContext
{
    public DbSet<Esporte>? Esporte { get; set; }
    public DbSet<Atleta>?  Atleta { get; set; }
    public DbSet<Time>?  Time { get; set; }
    
    public InterclasseContext(DbContextOptions<InterclasseContext> options) : base(options)
    {
        
    }
}