using Microsoft.EntityFrameworkCore;
using ProjetoUrgencia.Models;

namespace ProjetoUrgencia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Relacionamento 1:N exemplo
            modelBuilder.Entity<Chamado>()
                        .HasOne(c => c.Usuario)
                        .WithMany(u => u.Chamados)
                        .HasForeignKey(c => c.UsuarioId);
        }
    }
}
