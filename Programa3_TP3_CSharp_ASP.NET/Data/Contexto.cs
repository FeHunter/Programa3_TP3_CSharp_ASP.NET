using Microsoft.EntityFrameworkCore;
using Programa3_TP3_CSharp_ASP.NET.Models;

namespace Programa3_TP3_CSharp_ASP.NET.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasOne(p => p.Produto)
                .WithMany(c => c.Categorias)
                .HasForeignKey(p => p.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
