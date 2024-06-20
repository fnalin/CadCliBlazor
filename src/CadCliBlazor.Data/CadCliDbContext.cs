using CadCliBlazor.Data.Config;
using CadCliBlazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadCliBlazor.Data;

public class CadCliDbContext (DbContextOptions<CadCliDbContext> options) : DbContext (options)
{
    public DbSet<Cliente> Clientes => Set<Cliente>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new ClienteConfig());
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CadCliDbContext).Assembly);
    }
}