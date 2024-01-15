using Microsoft.EntityFrameworkCore;
using SmartHint.Core.Entities;
using System.Reflection;


namespace SmartHint.Infrastucture
{
    public class SmartHintDbContext : DbContext
    {
        public SmartHintDbContext(DbContextOptions<SmartHintDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
