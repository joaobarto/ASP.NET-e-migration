using Microsoft.EntityFrameworkCore;

namespace MinhaAplicacao.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Adicione DbSets para suas entidades aqui
        // public DbSet<MinhaEntidade> MinhaEntidades { get; set; }
    }
}