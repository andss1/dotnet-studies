using Microsoft.EntityFrameworkCore;

namespace aspnet_mvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Server=DESKTOP-P0CRGLM;Database=Testemvc;Integrated Security=True");
        }
    }
}
