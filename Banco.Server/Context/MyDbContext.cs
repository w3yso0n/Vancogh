using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace banco.Banco.Server.Context;

using banco.Banco.Server.Models;

public interface IMyDbContext
{
    DbSet<Cuenta> Cuentas { get; set; }
    DbSet<Usuario> Usuarios { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;

    public MyDbContext(IConfiguration _config)
    {
        config = _config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer(config.GetConnectionString("CRUD"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tablas de la base de datos
    // se pone las entidades en cada dbset
    public DbSet<Cuenta> Cuentas { set; get; } = null;

    public DbSet<Usuario> Usuarios { set; get; } = null;



    #endregion

}