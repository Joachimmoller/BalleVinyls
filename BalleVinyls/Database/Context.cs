using BalleVinyls.Models;

namespace BalleVinyls.Database;

public class Context : DbContext, IContext
{
    public DbSet<Artist> Artists { get; }
    public DbSet<Album> Albums { get; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<Attribute>();
        modelBuilder.Entity<Artist>().HasMany<Album>(a => a.Albums).WithMany(al => al.Artists);
        modelBuilder.Entity<Album>().HasMany<Artist>(al => al.Artists).WithMany(a => a.Albums);
        
        base.OnModelCreating(modelBuilder);
        
    }
}