using BalleVinyls.Models;

namespace BalleVinyls.Database;

public interface IContext : IDisposable
{
        DbSet<Artist> Artists { get; }
        DbSet<Album> Albums { get;  }
   
        int SaveChanges();
}